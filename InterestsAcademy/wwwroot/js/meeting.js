﻿/*const { param } = require("jquery");*/


var transitionEnd = 'webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend';
var transitionsSupported = ($('.csstransitions').length > 0);

if (!transitionsSupported) transitionEnd = 'noTransition';

$(document).ready(function () {

    document.getElementById('load').style.display = 'none';
    document.getElementById('load').classList.remove('mt-lg-5');
    document.getElementById('schedule').style.display = 'block';

    if (document.getElementById('add-btn') != null) {
        document.getElementById('add-btn').style.display = 'flex';

    }
});

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/activityHub")
    .build();

let url2 = new URL(window.location);
let params2 = url2.searchParams;
let isTeacher2 = params2.get('isTeacher');
let isCourse2 = params2.get('isCourse');

if (isTeacher2 == "False" && isCourse2=="False") {
document.getElementById('addMeeting').addEventListener('click', () => {
    Array.from(document.getElementsByClassName('text-danger')).forEach(e => e.style.display = 'none')
})
}

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

// Start the connection.
start()

function toUnicode(str) {
    let unicodeString = '';
    for (let i = 0; i < str.length; i++) {
        const unicodeChar = str.charCodeAt(i).toString(16).toUpperCase();
        unicodeString += `\\u${'0'.repeat(4 - unicodeChar.length)}${unicodeChar}`;
    }
    return unicodeString;
}




if (isTeacher2 == "False" && isCourse2 == "False") {
    function create(e) {


        e.preventDefault();
        let formData = new FormData(e.target);
        let { courseId, topic, start, end } = Object.fromEntries(formData);

        let dataArr = [courseId, topic, start, end];

        

        let data = new FormData();
        data.append('courseId', courseId);
        data.append('topic', topic);
        data.append('start', start);
        data.append('end', end);

       


        let validationSpans = document.getElementsByClassName('text-danger');

        dataArr.forEach((element, index) => {
            if (element == '') {
                validationSpans[index].style.display = 'block';
            }
            else {
                validationSpans[index].style.display = 'none';
            }
        });


        if (Array.from(validationSpans).some(v => v.style.display == 'block') != true) {

            let startDate = new Date(start);
            let endDate = new Date(end);

            let startHour = startDate.getHours();
            let endHour = endDate.getHours();

            if (startHour < 9 || endHour > 18) {
                toastr.error('\u0421\u0440\u0435\u0449\u0430\u0442\u0430\u0020\u0442\u0440\u044f\u0431\u0432\u0430\u0020\u0434\u0430\u0020\u0435\u0020\u043c\u0435\u0436\u0434\u0443\u0020\u0039\u003a\u0030\u0030\u0020\u0438\u0020\u0031\u0038\u003a\u0030\u0030\u0020\u0447\u0430\u0441\u0430'.normalize())
            }
            else if (startDate < new Date()) {

                toastr.error('\u041d\u0430\u0447\u0430\u043b\u043e\u0442\u043e\u0020\u043d\u0430\u0020\u0441\u0440\u0435\u0449\u0430\u0442\u0430\u0020\u043d\u0435\u0020\u043c\u043e\u0436\u0435\u0020\u0434\u0430\u0020\u0435\u0020\u043f\u043e\u002d\u0440\u0430\u043d\u043e\u0020\u043e\u0442\u0020\u043c\u043e\u043c\u0435\u043d\u0442\u0430\u0020\u043d\u0430\u0020\u0441\u044a\u0437\u0434\u0430\u0432\u0430\u043d\u0435'.normalize());

            }
            else if (endDate < startDate) {
                toastr.error('\u041a\u0440\u0430\u044f\u0020\u043d\u0430\u0020\u0441\u0440\u0435\u0449\u0430\u0442\u0430\u0020\u043d\u0435\u0020\u043c\u043e\u0436\u0435\u0020\u0434\u0430\u0020\u0435\u0020\u043f\u0440\u0435\u0434\u0438\u0020\u043d\u0435\u0439\u043d\u043e\u0442\u043e\u0020\u043d\u0430\u0447\u0430\u043b\u043e'.normalize());
            }
            else if (endHour - startHour < 1) {
                toastr.error('\u041F\u0440\u043E\u0434\u044A\u043B\u0436\u0438\u0442\u0435\u043B\u043D\u043E\u0441\u0442\u0442\u0430 \u043D\u0430 \u0441\u0440\u0435\u0449\u0430\u0442\u0430 \u0442\u0440\u044F\u0431\u0432\u0430 \u0434\u0430 \u0435 \u043F\u043E\u043D\u0435 3 \u0447\u0430\u0441\u0430'.normalize());
            }
            else {

                let t = $("input[name='__RequestVerificationToken']").val();

                $.ajax({
                    type: "POST",
                    url: `/Activity/Create`,
                    data: data,
                    processData: false,
                    contentType: false,
                    headers: {
                        "RequestVerificationToken": t

                    },
                    success: async function (data) {
                        if (data) {

                            if (data.classIdNull) {
                                toastr.error('\u041d\u0435\u0020\u043c\u043e\u0436\u0435\u0020\u0434\u0430\u0020\u0434\u043e\u0431\u0430\u0432\u044f\u0442\u0435\u0020\u0441\u0440\u0435\u0449\u0430\u0020\u0431\u0435\u0437\u0020\u043a\u043b\u0430\u0441'.normalize())
                            }
                            else if (data.isExists) {
                                toastr.error('\u0421\u0440\u0435\u0449\u0430\u0020\u043f\u043e\u0020\u0442\u043e\u0432\u0430\u0020\u0432\u0440\u0435\u043c\u0435\u0020\u0432\u0435\u0447\u0435\u0020\u0441\u044a\u0449\u0435\u0441\u0442\u0432\u0443\u0432\u0430'.normalize());
                            }
                            else {
                                try {
                                    await connection.invoke("SendMeeting", data.meetingId, data.receiversIds);
                                }
                                catch (err) {
                                    console.error(err);
                                }
                                let url = new URL(window.location);
                                let params = url.searchParams;
                                let days = parseInt(params.get('days'));
                                let isTeacherView = Boolean(params.get('isTeacher'));
                                let isCourseView = Boolean(params.get('isCourse'));
                                let groupId = params.get('groupId');

                                if (isNaN(days)) {
                                    days = 0;
                                }

                                if (isTeacher2=='True') {
                                    window.location = `${url.origin}/Activity/All?days=${days}&&groupId=${groupId}&isTeacher=true&isCourse=false`
                                } else if (isCourse2 == 'True') {
                                    window.location = `${url.origin}/Activity/All?days=${days}&&groupId=${groupId}&isTeacher=false&isCourse=true`

                                } else {
                                    window.location = `${url.origin}/Activity/All?days=${days}&&groupId=${groupId}&isTeacher=false&isCourse=false`

                                }

                               
                            }


                        }

                        console.log('Request added successfully');
                    },
                    error: function (error) {
                        toastr.error("\u041D\u0435\u043F\u0440\u0430\u0432\u0438\u043B\u0435\u043D \u043A\u0440\u0430\u0435\u043D \u0447\u0430\u0441".normalize());
                        console.log(error.message);
                        console.log(error.statusCode);
                    }
                });
            }
        }

    }
}

connection.on("ReceiveDelete", function (meetingId) {

    var divMeeting = document.getElementById(`${meetingId}`);

    divMeeting.parentNode.parentNode.removeChild(divMeeting.parentNode);

});

//connection.on("ReceiveEditedMeeting", async function (meetingId, receivers) {

//    var divMeeting = document.getElementById(`${meetingId}`);

//    divMeeting.parentNode.parentNode.removeChild(divMeeting.parentNode);


//    try {
//        await connection.invoke("SendMeeting", meetingId, receivers);
//    }
//    catch (err) {
//        console.error(err);
//    }
//    initEvent(meetingId);
//    placeEvents();

//});


connection.on("ReceiveMeeting", function (meeting, id) {

    let hours = {
        "09": "9",
        "10": "10",
        "11": "11",
        "12": "12",
        "13": "1",
        "14": "2",
        "15": "3",
        "16": "4",
        "17": "5",
        "18": "6"
    }

    let divParent = document.querySelector(`#day-${meeting.day} ul`);

    let li = document.createElement('li');
    li.classList.add('single-event');
    li.setAttribute('data-start', meeting.startHour);
    li.setAttribute('data-end', meeting.endHour);
    li.setAttribute('data-content', meeting.topic);
    li.setAttribute('data-event', 'event-1');
    //li.setAttribute('id', id);

    li.innerHTML = `<a href="#0" id="${id}">
                        <em class="event-name mt-2" id="${id}-topic">Тема: ${meeting.topic} </em>
                        <em class="event-name mt-2" id="${id}-courseName" style="font-size: 1rem;">Курс: ${meeting.courseName}</em>
                        <button class="delete-button"><svg viewBox="0 0 448 512" class="svgIcon"><path d="M135.2 17.7L128 32H32C14.3 32 0 46.3 0 64S14.3 96 32 96H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H320l-7.2-14.3C307.4 6.8 296.3 0 284.2 0H163.8c-12.1 0-23.2 6.8-28.6 17.7zM416 128H32L53.2 467c1.6 25.3 22.6 45 47.9 45H346.9c25.3 0 46.3-19.7 47.9-45L416 128z"></path></svg></button>
		
                    </a>`;



    divParent.appendChild(li);

    initEvent(id);
    placeEvents();


});

if (isTeacher2 == "False" && isCourse2 == "False") {
    document.getElementById('addEvent').addEventListener('submit', create);
}

let animating = false;


function initEvent(id) {
    let self = $('#schedule');
    let modal = $('.event-modal')
    let singleEvents = $(`#${id}`);
    let eventsGroup = $('.events-group');

    singleEvents.each(function () {

        var durationLabel = '<span class="event-date">' + $(this).parent().data('start') + ' - ' + $(this).parent().data('end') + '</span>';
        if ($(this).has('span').length == 0)
            $(this).prepend($(durationLabel));



        $(this).on('click', function (event) {
            event.preventDefault();
            if (!animating) openModal($(this));
        });
    });


    modal.on('click', '.close', function (event) {
        event.preventDefault();
        if (!animating) closeModal(eventsGroup.find('.selected-event'));
    });
    self.on('click', '.cover-layer', function (event) {
        if (!animating && self.hasClass('modal-is-open')) closeModal(eventsGroup.find('.selected-event'));
    });
};

function placeEvents() {

    let self = $('#schedule');
    let singleEvents = $('.single-event');
    let timeline = self.find('.timeline');
    let timelineItems = timeline.find('li');
    let eventsGroup = $('.events-group');
    let eventSlotHeight = eventsGroup.eq(0).children('.top-info').outerHeight();
    let timelineUnitDuration = getScheduleTimestamp(timelineItems.eq(1).text()) - getScheduleTimestamp(timelineItems.eq(0).text());
    let timelineStart = getScheduleTimestamp(timelineItems.eq(0).text());
    singleEvents.each(function () {

        var start = getScheduleTimestamp($(this).attr('data-start')),
            duration = getScheduleTimestamp($(this).attr('data-end')) - start;

        var eventTop = eventSlotHeight * (start - timelineStart) / timelineUnitDuration,
            eventHeight = eventSlotHeight * duration / timelineUnitDuration;

        $(this).css({
            top: (eventTop - 1) + 'px',
            height: (eventHeight + 1) + 'px'
        });
    });

    self.removeClass('loading');
};
function openModal(event) {

    let self = $('#schedule');
    let modal = $('.event-modal')
    let modalHeaderBg = modal.find('.header-bg');
    let modalHeader = modal.find('.header');
    let modalBody = modal.find('.body');
    let modalBodyBg = modal.find('.body-bg');
    let modalMaxWidth = 800;
    let modalMaxHeight = 480;

    animating = true;

    let meetingId = event.attr('id');

    let display = meetingId == '' ? 'none' : 'flex';

    let t = $("input[name='__RequestVerificationToken']").val();

    $.ajax({
        type: 'GET',
        url: `/Activity/Details/${meetingId}`,
        dataType: 'json',
        headers: {
            "RequestVerificationToken": t
        },
        success: function (data) {
            if (data.isExists) {
                //update event name and time
                let eventName = '';
                event.find('.event-name').each(function () {
                    eventName += $(this).text() + ' ';
                });

                modalHeader.find('.event-name').text(eventName);
                modalHeader.find('.event-date').text(event.find('.event-date').text());
                if (data.isTeacher) {

                    modalHeader.find('.d-flex').html(`<div class="mt-4" style="display: flex; z-index:3; "><a href="/Activity/Delete/${meetingId}" class="btn btn-danger" style="font-size: large;margin-right: 1rem;">Delete</a><a href="/Activity/Edit/${meetingId}" class="btn btn-warning"  style="font-size: large">Edit</a></div>`)
                }
                modal.attr('data-event', event.parent().attr('data-event'));

                //update event content
                let value = event.parent().attr('data-content');

               
                

                modalBody.find('.event-info').html(`
                                                    </div> 
                                                    
                                                    
                                                    <h4 style="margin-top: 10px">Учител</h4>
                                                    <div class="img-div">
                                                        <img class="image--cover" src="${data.activity.course.teachet.user.profilePictureUrl}"></img>
                                                        <div style="margin-left: 1rem;font-weight: 400;">${data.activity.course.teachet.user.name}</div>
                                                    </div>
                                                    
                                                   
                                                 </div>`);

                modalBody.find('.event-info').css('opacity: 1');

               




                self.addClass('content-loaded');

                self.addClass('modal-is-open');

                setTimeout(function () {
                    event.parent('li').addClass('selected-event');
                }, 10);


                var eventTop = event.offset().top - $(window).scrollTop(),
                    eventLeft = event.offset().left,
                    eventHeight = event.innerHeight(),
                    eventWidth = event.innerWidth();

                var windowWidth = $(window).width(),
                    windowHeight = $(window).height();

                var modalWidth = (windowWidth * .8 > modalMaxWidth) ? modalMaxWidth : windowWidth * .8,
                    modalHeight = (windowHeight * .8 > modalMaxHeight) ? modalMaxHeight : windowHeight * .8;

                var modalTranslateX = parseInt((windowWidth - modalWidth) / 2 - eventLeft),
                    modalTranslateY = parseInt((windowHeight - modalHeight) / 2 - eventTop);

                var HeaderBgScaleY = modalHeight / eventHeight,
                    BodyBgScaleX = (modalWidth - eventWidth);

                modal.css({
                    top: eventTop + 'px',
                    left: eventLeft + 'px',
                    height: modalHeight + 'px',
                    width: modalWidth + 'px',
                });
                transformElement(modal, 'translateY(' + modalTranslateY + 'px) translateX(' + modalTranslateX + 'px)');

                modalHeader.css({
                    width: eventWidth + 'px',
                });
                modalBody.css({
                    marginLeft: eventWidth + 'px',
                });

                modalHeaderBg.css({
                    height: eventHeight + 'px',
                    width: eventWidth + 'px',
                });
                transformElement(modalHeaderBg, 'scaleY(' + HeaderBgScaleY + ')');

                modalHeaderBg.one(transitionEnd, function () {
                    modalHeaderBg.off(transitionEnd);
                    animating = false;
                    self.addClass('animation-completed');
                });



                if (!transitionsSupported) modal.add(modalHeaderBg).trigger(transitionEnd);



            }
            else {
                toastr.error('\u0422\u0430\u0437\u0438\u0020\u0441\u0440\u0435\u0449\u0430\u0020\u043d\u0435\u0020\u0441\u044a\u0449\u0435\u0441\u0442\u0432\u0443\u0432\u0430'.normalize());
            }

        }


    })



};

function closeModal(event) {
    let self = $('#schedule');
    let modal = $('.event-modal')
    let modalHeaderBg = modal.find('.header-bg');
    let modalHeader = modal.find('.header');
    let modalBody = modal.find('.body');
    let modalBodyBg = modal.find('.body-bg');

    document.getElementById('materials').innerHTML = '';


    animating = true;

    var eventTop = event.offset().top - $(window).scrollTop(),
        eventLeft = event.offset().left,
        eventHeight = event.innerHeight(),
        eventWidth = event.innerWidth();

    var modalTop = Number(modal.css('top').replace('px', '')),
        modalLeft = Number(modal.css('left').replace('px', ''));

    var modalTranslateX = eventLeft - modalLeft,
        modalTranslateY = eventTop - modalTop;

    self.element.removeClass('animation-completed modal-is-open');

    modal.css({
        width: eventWidth + 'px',
        height: eventHeight + 'px'
    });
    transformElement(modal, 'translateX(' + modalTranslateX + 'px) translateY(' + modalTranslateY + 'px)');

    transformElement(modalBodyBg, 'scaleX(0) scaleY(1)');
    transformElement(modalHeaderBg, 'scaleY(1)');

    modalHeaderBg.one(transitionEnd, function () {
        modalHeaderBg.off(transitionEnd);
        modal.addClass('no-transition');
        setTimeout(function () {
           modal.add(modalHeader).add(modalBody).add(modalHeaderBg).add(modalBodyBg).attr('style', '');
        }, 10);
        setTimeout(function () {
            self.modal.removeClass('no-transition');
        }, 20);

        animating = false;
        self.removeClass('content-loaded');
        event.removeClass('selected-event');
    });


    if (!transitionsSupported) modal.add(modalHeaderBg).trigger(transitionEnd);
}

function getScheduleTimestamp(time) {

    time = time.replace(/ /g, '');
    var timeArray = time.split(':');
    var timeStamp = parseInt(timeArray[0]) * 60 + parseInt(timeArray[1]);
    return timeStamp;
}

function transformElement(element, value) {
    element.css({
        '-moz-transform': value,
        '-webkit-transform': value,
        '-ms-transform': value,
        '-o-transform': value,
        'transform': value
    });
}






