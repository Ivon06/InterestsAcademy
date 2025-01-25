"use strict"

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/requestHub")
    .build();

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    }
    catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});


start()

document.getElementById('send').addEventListener('click', function (event) {

    let email = String(document.getElementById('email').value);
    let name = String(document.getElementById('name').value);
    let course = String(document.getElementById('course').value);

    let data = new FormData();

    if (email == "") {
        document.getElementsByClassName('text-danger')[1].style.display = 'block';

    }

    if (name == "") {
        document.getElementsByClassName('text-danger')[0].style.display = 'block';

    } else {
        document.getElementsByClassName('text-danger')[1].style.display = 'none';
        document.getElementsByClassName('text-danger')[0].style.display = 'none';

        data.append('studentEmail', email);
        data.append('studentName', name);
        data.append('courseName', course);

        let t = $("input[name='__RequestVerificationToken']").val();

        $.ajax({
            type: "POST",
            url: `/Request/Create`,
            data: {
                'studentEmail': email,
                'studentName': name,
                'courseName': course
            },
            dataType: "json",
            headers: {
                "RequestVerificationToken": t

            },
            success: async function (data) {
                if (data) {
                    try {
                        await connection.invoke("SendRequest", data.requestId, data.teacherUserId, name, email);

                    }
                    catch (err) {
                        console.error(err);
                    }

                    let url = new URL(window.location);
                    let params = url.searchParams;

                    window.location = `${url.origin}/Course/All`;

                }

                console.log('Request added successfully');
            },
            error: async function (error) {
                console.log('err', error);
            }
        });
    }
});
