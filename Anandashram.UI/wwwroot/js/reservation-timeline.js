let timelineChart;

function loadTimeline() {
    debugger;
    let start = $("#startDate").val();
    let end = $("#endDate").val();

    if (!start || !end) {
        alert("Please select both dates");
        return;
    }

    $.post("/Reservation/GetTimelineData",
        { startDate: start, endDate: end },
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
                    borderWidth: 20,
                    borderColor: palette(index),
                    backgroundColor: palette(index) + "55",
                    barPercentage: 50.0,
                    categoryPercentage: 0.5
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
