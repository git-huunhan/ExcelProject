// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTable').DataTable({
        dom: 'lBrtip',
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]],
        "language": {
            "lengthMenu": "Hiển thị _MENU_ hàng",
            "info": "Hiển thị từ hàng _START_ đến hàng _END_",
            "paginate": {
                "first": "Đầu",
                "previous": "Trước",
                "next": "Sau", 
                "last": "Cuối",
            }  
        },
        buttons: [
            {
                text: 'Chọn cột để xuất',
                extend: 'colvis',
                collectionLayout: 'fixed four-column',
            },
            {
                extend: 'excel',
                title: '',
                filename: 'Data Export',
                text: 'Xuất tập tin Excel',
                
                exportOptions: {
                    columns: ':visible',
                }
            },
            {
                extend: 'print',
                text: 'In tập tin',
                exportOptions: {
                    columns: ':visible'
                }
            },
        ],
        columnDefs: [{
            targets: '_all',
            visible: true
        }], 
        scrollX: true,
    });
});

