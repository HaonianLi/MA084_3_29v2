
function filterColumn2(i) {
    $('#data').DataTable().column(i).search(
        $('#col' + i + '_filter').val(),
        //,
        //$('#col'+i+'_regex').prop('checked'),
        $('#col' + i + '_smart')
    ).draw();
}

$(document).ready(function () {
    $('#data').DataTable();

    //$('input.global_filter').on( 'keyup click', function () {
    //    filterGlobal();
    //} );

    $('input.column_filter').on('keyup click', function () {
        filterColumn2($(this).parents('tr').attr('data-column'));
    });
});


$(document).ready(function () {
    $('#data tbody tr:even').addClass("silver");
    $('#data tbody tr').mouseover(function () {
        $(this).addClass('dataHover');
    });
    $('#data tbody tr').mouseout(function () {
        $(this).removeClass('dataHover');
    });
});


//function filterGlobal() {
//    $('#article').DataTable().search(
//        $('#global_filter').val(),
//        //,
//        //$('#global_regex').prop('checked'),
//        $('#global_smart')
//    ).draw();
//}

function filterColumn(i) {
    $('#article').DataTable().column(i).search(
        $('#col' + i + '_filter').val(),
        //,
        //$('#col'+i+'_regex').prop('checked'),
        $('#col' + i + '_smart')
    ).draw();
}

//$(document).ready(function () {
//    $('#clothes').DataTable();

//    //$('input.global_filter').on('keyup click', function () {
//    //    filterGlobal();
//    //});

//    $('input.column_filter').on('keyup click', function () {
//        filterColumn($(this).parents('tr').attr('data-column'));
//    });
//});

$(document).ready(function () {
    $('#clothes tbody tr:even').addClass("silver");
    $('#clothes tbody tr').mouseover(function () {
        $(this).addClass('dataHover');
    });
    $('#clothes tbody tr').mouseout(function () {
        $(this).removeClass('dataHover');
    });
});



function filterColumn3(i) {
    $('#AspNetUser').DataTable().column(i).search(
        $('#col' + i + '_filter').val(),
        //,
        //$('#col'+i+'_regex').prop('checked'),
        $('#col' + i + '_smart')
    ).draw();
}

$(document).ready(function () {
    $('#AspNetUser').DataTable();

    //$('input.global_filter').on('keyup click', function () {
    //    filterGlobal();
    //});

    $('input.column_filter').on('keyup click', function () {
        filterColumn3($(this).parents('tr').attr('data-column'));
    });
});

$(document).ready(function () {
    $('#AspNetUser tbody tr:even').addClass("silver");
    $('#AspNetUser tbody tr').mouseover(function () {
        $(this).addClass('dataHover');
    });
    $('#AspNetUser tbody tr').mouseout(function () {
        $(this).removeClass('dataHover');
    });
});


$(document).ready(function () {
    $('#clothes').DataTable({
        initComplete: function () {
            this.api().columns().every(function () {
                var column = this;
                var select = $('<select><option value=""></option></select>')
                    .appendTo($(column.footer()).empty())
                    .on('change', function () {
                        var val = $.fn.dataTable.util.escapeRegex(
                            $(this).val()
                        );

                        column
                            .search(val ? '^' + val + '$' : '', true, false)
                            .draw();
                    });

                column.data().unique().sort().each(function (d, j) {
                    select.append('<option value="' + d + '">' + d + '</option>')
                });
            });
        }
    });
});





//$(document).ready(function () {
//    // Setup - add a text input to each footer cell
//    $('#clothes tfoot th').each(function () {
//        var title = $(this).text();
//        $(this).html('<input type="text" placeholder="Search ' + title + '" />');
//    });

//    // DataTable
//    var table = $('#clothes').DataTable();

//    // Apply the search
//    table.columns().every(function () {
//        var that = this;

//        $('input', this.footer()).on('keyup change', function () {
//            if (that.search() !== this.value) {
//                that
//                    .search(this.value)
//                    .draw();
//            }
//        });
//    });
//});

