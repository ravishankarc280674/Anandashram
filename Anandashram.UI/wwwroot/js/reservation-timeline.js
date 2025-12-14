let timelineChart;

function loadTimeline() {
    debugger;
    const buildings = getSelectedBuildings();
    let start = $("#startDate").val();
    let end = $("#endDate").val();

    if (!start || !end) {
        alert("Please select both dates");
        return;
    }

    $.post("/Reservation/GetTimelineData",
        { startDate: start, endDate: end, buildings: buildings },
        function (data) {

            if (!data || data.length === 0) {
                alert("No records found");
                return;
            }

            if (timelineChart) timelineChart.destroy();

            // ---- Rooms grouped + ordered ----
            const rooms = [...new Set(data.map(x => `${x.roomName} (${x.capacity})`))];

            // ---- Convert to datasets ----
            const datasets = data.map((item, index) => {
                const yLabel = `${item.roomName} (${item.capacity})`;

                return {
                    label: `${item.devoteeCode} : ${item.devoteeName} : ${item.allocated}`,
                    data: [{
                        x: [
                            new Date(item.fromDate).getTime(),
                            new Date(item.toDate).getTime()
                        ],
                        y: yLabel
                    }],
                    borderWidth: 1,
                    borderColor: palette(index),
                    backgroundColor: palette(index),
                    barPercentage: 80.0,
                    categoryPercentage: 0.2
                };
            });

            // ---- Chart Render ----
            const ctx = document.getElementById("timelineChart").getContext("2d");

            timelineChart = new Chart(ctx, {
                type: "bar",
                data: { datasets },
                options: {
                    indexAxis: "y",
                    responsive: true,
                    maintainAspectRatio: false,
                    scales: {
                        y: {
                            type: "category",
                            labels: rooms,
                            title: { display: true, text: "Rooms (Capacity)" },
                            offset: true,
                            ticks: {
                                autoSkip: false,
                                maxRotation: 0,
                                minRotation: 0,
                                padding: 5
                            },
                            grid: {
                                display: true,
                                drawBorder: true
                            }
                        },
                        x: {
                            type: "time",
                            time: { unit: "day", tooltipFormat: "dd/MM/yyyy", },
                            title: { display: true, text: "Dates" },
                            grid: {
                                display: true
                            },
                            ticks: {
                                maxTicksLimit: 20
                            }
                        }
                    },
                    plugins: {
                        tooltip: {
                            callbacks: {
                                label: ctx => ctx.dataset.label
                            }
                        },
                        legend: { display: false }
                    }
                }
            });

            // ---- Horizontal scroll ----
            $("#timelineWrapper").css({
                "overflow-x": "scroll",
                "white-space": "nowrap"
            });
        });
}


// ---- Color Palette ----
function palette(i) {
    const c = ["#1f77b4", "#ff7f0e", "#2ca02c",
        "#d62728", "#9467bd", "#8c564b", "#17becf"];
    return c[i % c.length];
}
function printChart() {
    const canvas = document.getElementById("timelineChart");
    const img = canvas.toDataURL("image/png");

    const win = window.open("", "_blank");
    win.document.write(`
        <html>
            <head>
                <title>Print Chart</title>
            </head>
            <body style="margin:0; padding:0; text-align:center;">
                <img src="${img}" style="width:100%;"/>
            </body>
        </html>
    `);
    win.document.close();

    setTimeout(() => win.print(), 400);
}

function exportPdf() {
    window.location.href = "/Reservation/ExportChartPdf?startDate="
        + document.getElementById("startDate").value
        + "&endDate=" + document.getElementById("endDate").value;
}

function exportExcel() {
    window.location.href = "/Reservation/ExportChartExcel?startDate="
        + document.getElementById("startDate").value
        + "&endDate=" + document.getElementById("endDate").value;
}

document.addEventListener("DOMContentLoaded", function () {

    const selectAll = document.getElementById("selectAllBuildings");
    const buildingChecks = document.querySelectorAll(".building-checkbox");
    const dropdownBtn = document.getElementById("buildingDropdown");

    function updateButtonText() {
        const checked = [...buildingChecks].filter(c => c.checked);

        if (checked.length === buildingChecks.length) {
            dropdownBtn.textContent = "All Buildings Selected";
        }
        else if (checked.length === 0) {
            dropdownBtn.textContent = "No Building Selected";
        }
        else {
            dropdownBtn.textContent = checked.length + " Building(s) Selected";
        }
    }

    // Select All toggle
    selectAll.addEventListener("change", function () {
        buildingChecks.forEach(c => c.checked = this.checked);
        updateButtonText();
    });

    // Individual change
    buildingChecks.forEach(cb => {
        cb.addEventListener("change", function () {
            selectAll.checked = [...buildingChecks].every(c => c.checked);
            updateButtonText();
        });
    });

    updateButtonText();
});

// Call this inside loadTimeline()
function getSelectedBuildings() {
    return [...document.querySelectorAll(".building-checkbox:checked")]
        .map(cb => parseInt(cb.value));
}