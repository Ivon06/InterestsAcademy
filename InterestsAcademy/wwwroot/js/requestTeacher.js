
"use strict";



var connection = new signalR.HubConnectionBuilder()
    .withUrl("/requestHub")
    .build();

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

start(); 

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
                    <li><a class="dropdown-item" href="/Request/Accept?requestId=${requestId}">\u041f\u0440\u0438\u0435\u043c\u0438</a></li>
                    <li><a class="dropdown-item" onclick="changeStatus('Rejected', ${requestId})">\u041e\u0442\u043a\u0430\u0436\u0438</a></li>
                </ul>
            </div>
        </td>
    `;

    let table = document.getElementById('requests');
    if (table) {
        table.appendChild(tr);
    } else {
        console.error('Table with ID "requests" not found.');
    }
});

connection.start()
    .then(() => console.log("SignalR connected."))
    .catch(err => console.error("SignalR connection failed:", err));



//"use strict"

//var connection = new signalR.HubConnectionBuilder()
//    .withUrl("/requestHub")
//    .build();



//connection.on("ReceiveRequest", function (studentEmail, studentName, status,  requestId, teacherId, courseId){
//    let tr = document.createElement('tr');
//    let colors = {
//        "Waiting": "warning",
//        "Accepted": "success",
//        "Rejected": "danger"
//    }

//    tr.innerHTML = `<td>photo</td>
//					<td>${studentName}</td >
//					<td>${studentEmail}</td>
//					<td>
//        <div class="dropdown" id="dropdown-${requestId}">
//            <a class="badge badge-soft-${colors[status]} p-2 team-status dropdown-toggle" id="status-${requestId}" style="text-decoration: none; font - size: 1rem" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
//                ${statusBg[status]}
//            </a>

            
//                <ul class="dropdown-menu">
//                    <li><a class="dropdown-item"  href="/Request/Accept?requestId=${requestId} >\u041f\u0440\u0438\u0435\u043c\u0438</a></li>
//                    <li><a class="dropdown-item" onclick="changeStatus('Rejected', ${requestId})">\u041e\u0442\u043a\u0430\u0436\u0438</a></li>
//                </ul>
            




//        </div>
//        </td>`.normalize();

//    let table = document.getElementById('requests');
//    table.appendChild(tr);




    
//})