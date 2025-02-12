var sliderCards = (function (document, $) {

    'use strict';

    var $sliderCards = $('.slider--cards'),
        $list = $('#card-list'),
        $listItems = $('#card-list li'),
        $nItems = $listItems.length,
        $nView = 3,
        autoSlider,
        $current = 0,
        $isAuto = true,
        $autoTime = 2500,

        _init = function () {
            _setWidth();
            _eventInit();
        },

        _setWidth = function () {
            $list.css({
                'width': ~~(100 * ($nItems / $nView)) + '%'
            });
            $listItems.css('width', 100 / $nItems + '%');
            $sliderCards.css({ opacity: 1 });
        },

        _eventInit = function () {

            $.each($listItems, function (i) {
                var $this = $(this);
                $this.on('click', function (e) {
                    e.preventDefault();
                    _stopAuto(i);
                    _moveTo($this, i);
                });
            });

            autoSlider = setInterval(_autoMove, $autoTime);
        },

        _moveTo = function (obj, index) {

            obj.find('.card').addClass('active');
            $listItems.not(obj).find('.card').removeClass('active');

            $list.css({
                transform: `translateX(${-(index * 220)}px)`
            });
        },

        _autoMove = function () {
            if ($isAuto) {
                $current = ($current + 1) % $nItems;
            }
            _moveTo($listItems.eq($current), $current);
        },

        _stopAuto = function (index) {
            clearInterval(autoSlider);
            $isAuto = false;
            _autoMove(index);
        };

    return {
        init: _init
    };

})(document, jQuery);

$(window).on('load', function () {
    sliderCards.init();
});
$(window).scroll(function () {
    if ($(this).scrollTop() > 50) {
        $(".navv").addClass("scrolled");
    } else {
        $(".navv").removeClass("scrolled");
    }
});

