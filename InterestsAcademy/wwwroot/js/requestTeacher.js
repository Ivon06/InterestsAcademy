
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
        <td>photo</td>
        <td>${studentName}</td>
        <td>${studentEmail}</td>
        <td>
            <div class="dropdown" id="dropdown-${requestId}">
                <a class="badge badge-soft-${colors[status]} p-2 team-status dropdown-toggle" id="status-${requestId}" style="text-decoration: none; font-size: 1rem" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                    ${statusBg[status]}
                </a>
                <ul class="dropdown-menu">
                    <li><a class="dropdown-item" id="accept_${requestId}" >\u041f\u0440\u0438\u0435\u043c\u0438</a></li>
                    <li><a class="dropdown-item" onclick="changeStatus('Rejected', ${requestId})">\u041e\u0442\u043a\u0430\u0436\u0438</a></li>
                </ul>
            </div>
        </td>
    `;

    ///*href=" /Request/Accept?requestId = ${ requestId }*/

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


//let acceptButton = document.getElementById(`accept-${requestId}`);


//acceptButton.addEventListener('click', function () {

//    $.ajax({
//        method: 'POST',
//        url: "/Request/EditStatus",
//        data: {
//            'requestId': requestId,
//            'status': "Accepted"
//        },
//        headers:
//        {
//            'RequestVerificationToken': token
//        },
//        datatype: 'json',
//        success: async function (data) {
//            if (data.isEdited) {
//                let newStatus = "Accepted";
//                try {
//                    await connection.invoke("ChangeRequestStatus", requestId, newStatus);
//                }
//                catch (err) {
//                    console.error(err)
//                }



//                let url = new URL(window.location);

//                window.location = `${url.origin}/Request/All`
//            }
//        },
//        error: function (err) {
//            console.error(err.message);
//        }
//    });


//})




//connection.on("ReceiveNewStatus", function (newStatus, id) {
//    let statusStyles = {
//        "Waiting": "warning",
//        "Rejected": "danger",
//        "Accepted": "success"
//    };



//    let oldStatus = document.getElementById(`status-${id}`).textContent.trim();

//    document.getElementById(`status-${id}`).textContent = statusBg[newStatus];
//    document.getElementById(`status-${id}`).classList.remove(`badge-soft-warning`);
//    document.getElementById(`status-${id}`).classList.add(`badge-soft-${statusStyles[newStatus]}`);

//})


//let acceptButton = document.getElementById('accept');
//let requestIdElement = document.getElementById('requestId');
//let status1 = document.getElementById('requestStatus').value;
//let token = $("input[name='__RequestVerificationToken']").val();


//acceptButton.addEventListener('click', function () {

//    let requestId = requestIdElement.value;

//    $.ajax({
//        method: 'POST',
//        url: "/Request/EditStatus",
//        data: {
//            'requestId': requestId,
//            'status': "Accepted"
//        },
//        headers:
//        {
//            'RequestVerificationToken': token
//        },
//        datatype: 'json',
//        success: async function (data) {
//            if (data.isEdited) {
//                let newStatus = "Accepted";
//                try {
//                    await connection.invoke("ChangeRequestStatus", requestId, newStatus);
//                }
//                catch (err) {
//                    console.error(err)
//                }



//                let url = new URL(window.location);

//                window.location = `${url.origin}/Request/All`
//            }
//        },
//        error: function (err) {
//            console.error(err.message);
//        }
//    });


//})

//async function changeStatus(status, id) {
//    $.ajax({
//        method: 'POST',
//        url: "/Request/EditStatus",
//        data: {
//            'requestId': id,
//            'status': status
//        },
//        headers:
//        {
//            'RequestVerificationToken': token
//        },
//        datatype: 'json',
//        success: async function (data) {
//            if (data.isEdited) {
//                let newStatus = "Rejected";
//                try {
//                    await connection.invoke("ChangeRequestStatus", id, newStatus);
//                }
//                catch (err) {
//                    console.error(err)
//                }



//                let url = new URL(window.location);

//                window.location = `${url.origin}/Request/All`
//            }
//        },
//        error: function (err) {
//            console.error(err.message);
//        }
//    });

//}

//connection.on("ReceiveNewStatus", function (newStatus, id) {

//    let statusStyles = {
//        "Waiting": "warning",
//        "Rejected": "danger",
//        "Accepted": "success"
//    };



//    let oldStatus = document.getElementById(`status-${id}`).textContent.trim();

//    document.getElementById(`requestId`).textContent = statusBg[newStatus];
//    document.getElementById(`requestId`).classList.remove(`badge-soft-warning`);
//    document.getElementById(`requestId`).classList.add(`badge-soft-${statusStyles[newStatus]}`);

//    if (newStatus == "Accepted") {
//        document.getElementById(`btn-documents-${id}`).style.display = 'block';
//        document.getElementById(`btn-class-${id}`).style.display = 'none'
//    }
//    else {
//        document.getElementById(`btn-documents-${id}`).style.display = 'none';
//        document.getElementById(`btn-class-${id}`).style.display = 'block'
//    }


//})


