var connection = new signalR.HubConnectionBuilder()
    .withUrl("/activityHub")
    .build();

$(document).ready(function () {

    let divs = Array.from(document.getElementsByClassName('input-group'));
    for (let div of divs) {
        div.children[0].disabled = true
        div.children[1].style = 'transform: translateY(-50%) scale(0.8);background-color: #212121;padding: 0 .2em;color: #2196f3;'

    }

});

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

let elements = document.getElementsByClassName('single-event');

let url3 = new URL(window.location);
let params3 = url3.searchParams;
let isTeacher3 = params3.get('isTeacher');
let isCourse3 = params3.get('isCourse');

if (isTeacher3 == "True" && isCourse3 == "False") {

    
    	
    Array.from(elements).forEach(e => {
        let btn = document.createElement('button');
        btn.classList.add('delete-button');
        btn.innerHTML = '<svg viewBox="0 0 448 512" class="svgIcon"><path d="M135.2 17.7L128 32H32C14.3 32 0 46.3 0 64S14.3 96 32 96H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H320l-7.2-14.3C307.4 6.8 296.3 0 284.2 0H163.8c-12.1 0-23.2 6.8-28.6 17.7zM416 128H32L53.2 467c1.6 25.3 22.6 45 47.9 45H346.9c25.3 0 46.3-19.7 47.9-45L416 128z"></path>'

        let el = e.getElementsByClassName('link')[0];
        el.appendChild(btn);
    })
    
    //addDeleteButton(e.getElementsByClassName('link'), button))

  /*  button.addEventListener('click', deleteMeeting)*/
}
    


function addDeleteButton(el, button) {
    el[0].innerHtml = button;
}

function deleteMeeting(e) {

    e.preventDefault();

    let data = new FormData(e.target);

    let { title, start, end } = Object.fromEntries(data);


    let url = new URL(window.location);
    let path = url.pathname;
    let t = $("input[name='__RequestVerificationToken']").val();

    $.ajax({
        type: "POST",
        url: path,
        data: {
            'title': title,
            'end': end,
            'start': start,
            
        },
        dataType: "json",

        headers: {
            "RequestVerificationToken": t
        },

        success: async function (data) {
            if (data) {

                try {

                    await connection.invoke("DeleteMeeting", data.activityId, data.receiversIds)

                } catch (err) {
                    console.error(err);
                }

                let url = new URL(window.location);
                let params = url.searchParams;
                let days = parseInt(params.get('days'))

                if (isNaN(days)) {
                    days = 0;
                }

                window.location = `${url.origin}/Activity/All?days=${days}&&groupId=${groupId}&isTeacher=true&isCourse=false`

            }
        },
        error: function (err) {
            console.error(err);
        }


    })
}

//Array.from(document.getElementsByClassName('delete-button')).forEach(b => b.addEventListener('submit', deleteMeeting));

