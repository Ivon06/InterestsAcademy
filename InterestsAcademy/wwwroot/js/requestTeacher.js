
"use strict";



var connection = new signalR.HubConnectionBuilder()
    .withUrl("/requestHub")
    .build();

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});

start();

let statusBg = {
    "Waiting": "Waiting",
    "Accepted": "Accepted",
    "Rejected": "Rejected"
};

let colors = {
    "Waiting": "warning",
    "Accepted": "success",
    "Rejected": "danger"
};



connection.on("ReceiveRequest", function (studentEmail, studentName, status, requestId, teacherId, courseId) {
    let tr = document.createElement('tr');

    tr.innerHTML = `
        


        <td>${studentName}</td>
                                <td>${studentEmail}</td>
                                <td>
                                     <p class="badge badge-soft-${colors[status]} p-2 team-status" id="status-${requestId}" style="text-decoration: none; color:black; font-size: 1rem">
                                        ${statusBg[status]}
                                    </p>
                                </td>
                                <td>
                                    
                                        <input value="${requestId}" id="requestId" hidden />
                                        <input value="${status}" id="requestStatus" hidden />
                                        <button class="badge badge-soft-${colors[status]} p-2 team-status btn-approve" id="accept_${requestId}" >\u041f\u0440\u0438\u0435\u043c\u0438</button>
                                        <button class="badge badge-soft-${colors[status]} p-2 team-status btn-reject" onclick="changeStatus('Rejected', '${requestId}')">\u041e\u0442\u043a\u0430\u0436\u0438</button>
                                    
                                </td>
    `;


    let table = document.getElementById('requests');
    if (table) {
        table.appendChild(tr);
    } else {
        console.error('Table with ID "requests" not found.');
    }


});

let buttons = document.getElementsByClassName('accept-class');
let token = $('input:hidden[name="__RequestVerificationToken"]').val()

Array.from(buttons).forEach(b => b.addEventListener('click', function () {

    let requestId = b.id.split('_')[1];

    $.ajax({
        method: 'POST',
        url: "/Request/EditStatus",
        data: {
            'requestId': requestId,
            'status': "Accepted"
        },
        headers:
        {
            'RequestVerificationToken': token
        },
        datatype: 'json',
        success: async function (data) {
            if (data.isEdited) {
                let newStatus = "Accepted";
                try {
                    await connection.invoke("ChangeRequestStatus", requestId, newStatus);
                }
                catch (err) {
                    console.error(err)
                }

                let courseId = document.getElementById('courseId').value;

                let url = new URL(window.location);

                window.location = `${url.origin}/Request/All?courseId=${courseId}`
            }
        },
        error: function (err) {
            console.error(err.message);
        }
    });
}));





