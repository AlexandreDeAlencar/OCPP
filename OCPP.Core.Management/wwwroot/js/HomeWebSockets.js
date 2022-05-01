
$(document).ready(function ()
    {
        setInterval(function () {
            updateState();
        }, 3000)
    }
)

function updateState() {
    $.ajax({
        url: '/Home/Index',
        contentType: 'application/html ; charset:utf-8',
        type: 'GET',
        dataType: 'html',
        success: function (data)
        {
            var result = $('<div />').append(data).find('.tilegrid').html();
            $('.tilegrid').html(result);
        }
    });
}