/// <reference path="jquery-1.7.2.min.js" />

$(document).ready(function () {
    alert("12");
    if ($('#divApproved').length > 0) {
        $('#divApproved').css("display", "block");
    }

    //每间隔一秒更新一次提醒信息
    setInterval(GetUnreadCount, 1000);

    $('#aApproved').click(function () {
        var unreadCount = $('#spApproved').html();
        if (unreadCount >= 0) {
            window.location.replace(location.href);
        }
    });

});

/// <summary>
/// 返回未阅读的消息数目
/// </summary>
function GetUnreadCount() {
    $.ajax({
        type: "POST",
        contentType: "application/json",
        url: "api/Remind/UnreadCount",
        data: {},
        dataType: 'json',
        success:
        function (result) {
            if (result == null || result == '')
                return;

            if (result["d"].length > 0) {
                var data = eval('(' + result["d"] + ')');

                if ($('#divApproved').length > 0) {
                    $('#spApproved').html(data.Consultation);
                }
            }
        }
    });
}
