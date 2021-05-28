
function GenerarInformes(datos) {

    var lineas = document.getElementById('lineas').getContext('2d');
    var barras = document.getElementById('barras').getContext('2d');
    var circulo = document.getElementById('circulo').getContext('2d');

    backgrounds = ['rgb(178, 190, 195, 0.5)', 'rgb(108, 92, 231, 0.5)', 'rgb(230, 103, 103, 0.5)', 'rgb(9, 132, 227, 0.5)', 'rgb(0, 184, 148, 0.5)'];
    borders = ['rgb(178, 190, 195)', 'rgb(108, 92, 231)', 'rgb(230, 103, 103)', 'rgb(9, 132, 227)', 'rgb(0, 184, 148)'];
    lineDiagramDataSets = [];
    barDiagramDataSets = [];
    pieDiagramDataSets = [];
    datosNombre = []
    cantidades = [];

    datosjson.forEach(function (item, i) {
        datosNombre.push(datosjson[i].Nombre);
        cantidades.push(datosjson[i].Cantidad);
    });
    datosjson.forEach(function (item, i) {
        diagramDataSet = {
            label: datosjson[i].Nombre,
            backgroundColor: backgrounds[i],
            borderColor: borders[i],
            data: [0, datosjson[i].Cantidad],
            fill: false,

        }
        lineDiagramDataSets.push(diagramDataSet);
    });
    datosjson.forEach(function (item, i) {
        diagramDataSet = {
            label: datosjson[i].Nombre,
            backgroundColor: backgrounds[i],
            borderColor: borders[i],
            borderWidth: 1,
            data: [datosjson[i].Cantidad],
        }
        barDiagramDataSets.push(diagramDataSet);
    });


    //Graficas realizas con Chart.js
    // Grafica en linea
    var informe_lineas = new Chart(lineas, {
        type: 'line',
        data: {
            datasets: lineDiagramDataSets
        },
        options: {
            responsive: true,
            title: {
                display: true,
                text: 'Diagrama de lineas'
            },
            tooltips: {
                mode: 'index',
                intersect: false,
            },
            hover: {
                mode: 'nearest',
                intersect: true
            },
            scales: {
                yAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        labelString: 'Cantidad'
                    }
                }]
            }
        }
    });


    //Grafica de barras
    var informe_barras = new Chart(barras, {
        type: 'bar',

        data: {
            datasets: barDiagramDataSets
        },

        options: {
            title: {
                display: true,
                text: 'Diagrama de barras'
            },
            scales: {
                yAxes: [{
                    scaleLabel: {
                        display: true,
                        labelString: 'Cantidad'
                    },
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });

    var informe_circulo = new Chart(circulo, {
        type: 'pie',
        data: {
            labels: datosNombre,
            datasets: [{

                data: cantidades,
                backgroundColor: backgrounds,
                borderColor: borders,
                borderWidth: 1,
                barPercentage: .3,
            }]
        },
        options: {
            title: {
                display: true,
                text: 'Diagrama circular'
            },
        }

    });



    $(document).ready(function () {
        $("#descargar").click(function () {

            var diagramaLineas = document.getElementById('lineas');
            var diagramaBarras = document.getElementById('barras');
            var diagramaCirculo = document.getElementById('circulo');


            document.getElementById("imgLineas").value = diagramaLineas.toDataURL("image/png");
            document.getElementById("imgBarras").value = diagramaBarras.toDataURL("image/png");
            document.getElementById("imgCircular").value = diagramaCirculo.toDataURL("image/png");
            document.getElementById("formDescarga").submit();

        });


    });

}
