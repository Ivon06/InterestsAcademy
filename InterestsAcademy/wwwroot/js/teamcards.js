var sliderCards = (function (document, $) {
    "use strict";

    var $sliderCards = $(".slider--cards"),
        $list = $("#card-list"),
        $listItems = $("#card-list li"),
        $nItems = $listItems.length,
        $nView = 3, // Number of visible cards
        autoSlider,
        $current = 0,
        $isAuto = true,
        $autoTime = 2500,
        $cardWidth = 220, // Width of each card
        $startPos = 0,
        $dragging = false;

    function _init() {
        _duplicateCards();
        _setWidth();
        _eventInit();
    }

    // Duplicate first few cards at the end for infinite looping effect
    function _duplicateCards() {
        let cloneFirst = $listItems.slice(0, $nView).clone();
        $list.append(cloneFirst);
        $listItems = $("#card-list li"); // Update item count after cloning
        $nItems = $listItems.length;
    }

    function _setWidth() {
        $list.css({
            "width": ~~(100 * ($nItems / $nView)) + "%"
        });
        $listItems.css("width", 100 / $nItems + "%");
        $sliderCards.css({ opacity: 1 });
    }

    function _eventInit() {
        // Enable dragging functionality
        $sliderCards.on('mousedown touchstart', function (e) {
            e.preventDefault();
            $dragging = true;
            $startPos = e.pageX || e.originalEvent.touches[0].pageX; // Get initial drag position
            $sliderCards.css('cursor', 'grabbing'); // Change cursor to grabbing when dragging
        });

        $(document).on('mousemove touchmove', function (e) {
            if ($dragging) {
                var move = (e.pageX || e.originalEvent.touches[0].pageX) - $startPos; // Calculate drag movement
                $list.css('transform', `translateX(${move}px)`); // Move the slider based on drag distance
            }
        });

        $(document).on('mouseup touchend', function () {
            if ($dragging) {
                var finalPos = $list.position().left; // Final position after drag
                var newIndex = Math.round(Math.abs(finalPos) / $cardWidth); // Calculate the closest card
                _moveTo(newIndex);
                $dragging = false;
                $sliderCards.css('cursor', 'grab'); // Change cursor back
            }
        });

        autoSlider = setInterval(_autoMove, $autoTime); // Initial auto-slider
    }

    function _moveTo(index) {
        $list.css({
            transition: "transform 0.5s ease-in-out",
            transform: `translateX(${-(index * $cardWidth)}px)`
        });

        // If we reach the last cloned item, instantly reset to the original
        if (index >= $nItems - $nView) {
            setTimeout(() => {
                $list.css({
                    transition: "none",
                    transform: `translateX(0px)`
                });
            }, 500);
            $current = 0;
        } else {
            $current = index;
        }
    }

    function _autoMove() {
        if ($isAuto) {
            _moveTo($current + 1);
        }
    }

    return {
        init: _init
    };

})(document, jQuery);

$(window).on("load", function () {
    sliderCards.init();
});

$(window).scroll(function () {
    if ($(this).scrollTop() > 50) {
        $(".navv").addClass("scrolled");
    } else {
        $(".navv").removeClass("scrolled");
    }
});
