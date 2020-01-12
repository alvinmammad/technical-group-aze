(function ($) {
    "use strict";
    jQuery(document).on('ready', function () {

        // Feather Icon Js
        feather.replace();

        // Mean Menu
        jQuery('.mean-menu').meanmenu({
            meanScreenWidth: "991"
        });

        // Magnific Popup
        $('.popup-youtube').magnificPopup({
            disableOn: 320,
            type: 'iframe',
            mainClass: 'mfp-fade',
            removalDelay: 160,
            preloader: false,
            fixedContentPos: false
        });

        // Header Sticky
        $(window).on('scroll', function () {
            if ($(this).scrollTop() > 120) {
                $('#header').addClass("is-sticky");
            }
            else {
                $('#header').removeClass("is-sticky");
            }
        });

        // Popup Gallery
        $('.popup-btn').magnificPopup({
            type: 'image',
            gallery: {
                enabled: true
            }
        });

        // Works Slides
        var owl = $('.works-slides');
        owl.owlCarousel({
            loop: true,
            nav: false,
            autoplay: true,
            dots: false,
            responsive: {
                0: {
                    items: 1,
                },
                768: {
                    items: 2,
                },
                1200: {
                    items: 3,
                },
                1500: {
                    items: 4,
                }
            }
        });
        owl.on('mousewheel', '.owl-stage', function (e) {
            if (e.deltaY > 0) {
                owl.trigger('next.owl');
            } else {
                owl.trigger('prev.owl');
            }
            e.preventDefault();
        });

        // Boxes Slides
        var owl = $('.boxes-slides');
        owl.owlCarousel({
            loop: true,
            nav: false,
            autoplay: true,
            dots: false,
            responsive: {
                0: {
                    items: 1,
                },
                768: {
                    items: 2,
                },
                1200: {
                    items: 4,
                }
            }
        });
        owl.on('mousewheel', '.owl-stage', function (e) {
            if (e.deltaY > 0) {
                owl.trigger('next.owl');
            } else {
                owl.trigger('prev.owl');
            }
            e.preventDefault();
        });

        // Testimonials Slides
        var owl = $(".testimonials-slides");
        owl.owlCarousel({
            loop: false,
            nav: false,
            dots: true,
            autoplay: true,
            smartSpeed: 1000,
            autoplayTimeout: 5000,
            items: 1,
        });

        // Team Slides
        var owl = $(".owl-carousel");
        owl.owlCarousel({
            loop: true,
            nav: false,
            dots: true,
            autoplay: false,
            smartSpeed: 1000,
            autoplayTimeout: 5000,
            responsive: {
                0: {
                    items: 1,
                },
                768: {
                    items: 2,
                },
                1200: {
                    items: 4,
                },
                1500: {
                    items: 5,
                }
            }
        });

        // Feedback Carousel
        var $imagesSlider = $(".feedback-slides .client-feedback>div"),
            $thumbnailsSlider = $(".client-thumbnails>div");
        // images options
        $imagesSlider.slick({
            speed: 300,
            slidesToShow: 1,
            slidesToScroll: 1,
            cssEase: 'linear',
            fade: true,
            autoplay: true,
            draggable: true,
            asNavFor: ".client-thumbnails>div",
            prevArrow: '.client-feedback .prev-arrow',
            nextArrow: '.client-feedback .next-arrow'
        });
        // Thumbnails options
        $thumbnailsSlider.slick({
            speed: 300,
            slidesToShow: 5,
            slidesToScroll: 1,
            cssEase: 'linear',
            autoplay: true,
            centerMode: true,
            draggable: false,
            focusOnSelect: true,
            asNavFor: ".feedback-slides .client-feedback>div",
            prevArrow: '.client-thumbnails .prev-arrow',
            nextArrow: '.client-thumbnails .next-arrow',
        });
        var $caption = $('.feedback-slides .caption');
        var captionText = $('.client-feedback .slick-current img').attr('alt');
        updateCaption(captionText);
        $imagesSlider.on('beforeChange', function (event, slick, currentSlide, nextSlide) {
            $caption.addClass('hide');
        });
        $imagesSlider.on('afterChange', function (event, slick, currentSlide, nextSlide) {
            captionText = $('.client-feedback .slick-current img').attr('alt');
            updateCaption(captionText);
        });
        function updateCaption(text) {
            // if empty, add a no breaking space
            if (text === '') {
                text = '&nbsp;';
            }
            $caption.html(text);
            $caption.removeClass('hide');
        }

        // Go to Top
        $(function () {
            //Scroll event
            $(window).on('scroll', function () {
                var scrolled = $(window).scrollTop();
                if (scrolled > 300) $('.go-top').fadeIn('slow');
                if (scrolled < 300) $('.go-top').fadeOut('slow');
            });
            //Click event
            $('.go-top').on('click', function () {
                $("html, body").animate({ scrollTop: "0" }, 500);
            });
        });

        // FAQ Accordion
        $(function () {
            $('.accordion').find('.accordion-title').on('click', function () {
                // Adds Active Class
                $(this).toggleClass('active');
                // Expand or Collapse This Panel
                $(this).next().slideToggle('fast');
                // Hide The Other Panels
                $('.accordion-content').not($(this).next()).slideUp('fast');
                // Removes Active Class From Other Titles
                $('.accordion-title').not($(this)).removeClass('active');
            });
        });

        // Tabs
        $("#tabs li").on("click", function () {
            var tab = $(this).attr("id");
            if ($(this).hasClass("inactive")) {
                $(this).removeClass("inactive");
                $(this).addClass("active");
                $(this).siblings().removeClass("active").addClass("inactive");
                $("#" + tab + "_content").addClass("show");
                $("#" + tab + "_content").siblings("div").removeClass("show");
            }
        });

        // Count Time 
        function makeTimer() {
            var endTime = new Date("August 19, 2019 17:00:00 PDT");
            var endTime = (Date.parse(endTime)) / 1000;
            var now = new Date();
            var now = (Date.parse(now) / 1000);
            var timeLeft = endTime - now;
            var days = Math.floor(timeLeft / 86400);
            var hours = Math.floor((timeLeft - (days * 86400)) / 3600);
            var minutes = Math.floor((timeLeft - (days * 86400) - (hours * 3600)) / 60);
            var seconds = Math.floor((timeLeft - (days * 86400) - (hours * 3600) - (minutes * 60)));
            if (hours < "10") { hours = "0" + hours; }
            if (minutes < "10") { minutes = "0" + minutes; }
            if (seconds < "10") { seconds = "0" + seconds; }
            $("#days").html(days + "<span>Days</span>");
            $("#hours").html(hours + "<span>Hours</span>");
            $("#minutes").html(minutes + "<span>Minutes</span>");
            $("#seconds").html(seconds + "<span>Seconds</span>");
        }
        setInterval(function () { makeTimer(); }, 1000);

        // Products Details Image Slider
        $('.slickslide').slick({
            dots: true,
            speed: 500,
            fade: false,
            slide: 'li',
            slidesToShow: 1,
            autoplay: true,
            autoplaySpeed: 4000,
            prevArrow: false,
            nextArrow: false,
            responsive: [{
                breakpoint: 800,
                settings: {
                    arrows: false,
                    centerMode: false,
                    centerPadding: '40px',
                    variableWidth: false,
                    slidesToShow: 1,
                    dots: true
                },
                breakpoint: 1200,
                settings: {
                    arrows: false,
                    centerMode: false,
                    centerPadding: '40px',
                    variableWidth: false,
                    slidesToShow: 1,
                    dots: true
                }
            }],
            customPaging: function (slider, i) {
                return '<button class="tab">' + $('.slick-thumbs li:nth-child(' + (i + 1) + ')').html() + '</button>';
            }
        });

        // Partner Slides
        var owl = $(".partner-slides");
        owl.owlCarousel({
            loop: true,
            nav: false,
            dots: false,
            autoplay: true,
            smartSpeed: 1000,
            autoplayTimeout: 5000,
            responsive: {
                0: {
                    items: 2,
                },
                768: {
                    items: 4,
                },
                1200: {
                    items: 6,
                }
            }
        });

    });

    $(window).on('load', function () {
        // WOW JS
        if ($(".wow").length) {
            var wow = new WOW({
                boxClass: 'wow',      // animated element css class (default is wow)
                animateClass: 'animated', // animation css class (default is animated)
                offset: 20,          // distance to the element when triggering the animation (default is 0)
                mobile: true,       // trigger animations on mobile devices (default is true)
                live: true,       // act on asynchronously loaded content (default is true)
            });
            wow.init();
        }
    });

    jQuery(document).on('ready', function () {
        $('.odometer').appear(function (e) {
            var odo = $(".odometer");
            odo.each(function () {
                var countNumber = $(this).attr("data-count");
                $(this).html(countNumber);
            });
        });
    });

    // Preloader Area
    jQuery(window).on('load', function () {
        $('.preloader').fadeOut();
    });
}(jQuery));