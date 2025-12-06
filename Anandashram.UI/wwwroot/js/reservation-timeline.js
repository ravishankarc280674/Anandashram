let timelineChart;

function loadTimeline() {

    let start = document.getElementById("startDate").value;
    let end = document.getElementById("endDate").value;
    debugger;
    if (!start || !end) {
        alert("Please select both dates");
        return;
    }

    $.post("/Reservation/GetTimelineData",
        { startDate: start, endDate: end },
        function (data) {

            if (timelineChart) timelineChart.destroy();

            const rooms = [...new Set(data.map(x => x.roomName))];

            // Convert to datasets
            const datasets = data.map((item, index) => {
                return {
                    label: `${item.devoteeCode} : ${item.devoteeName} : ${item.allocated}`,
                    data: [{
                        x: [new Date(item.fromDate).getTime(),
                        new Date(item.toDate).getTime()],
                        y: item.roomName
                    }],
                    borderWidth: 25,
                    borderColor: palette(index),
                    backgroundColor: palette(index) + "55"
                };
            });

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
                            title: { display: true, text: "Rooms" }
                        },
                        x: {
                            type: "time",
                            time: { unit: "day" },
                            title: { display: true, text: "Dates" }
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
        });
}

// Colors
function palette(i) {
    const c = ["#1f77b4", "#ff7f0e", "#2ca02c",
        "#d62728", "#9467bd", "#8c564b"];
    return c[i % c.length];
}

// PDF Export
function exportPdf() {
    window.location.href = "/Reservation/ExportChartPdf?startDate="
        + document.getElementById("startDate").value
        + "&endDate=" + document.getElementById("endDate").value;
}

// Excel Export
function exportExcel() {
    window.location.href = "/Reservation/ExportChartExcel?startDate="
        + document.getElementById("startDate").value
        + "&endDate=" + document.getElementById("endDate").value;
}
