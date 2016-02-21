var menu = {
    Init: function () {
        console.log("menu");
        $(".menu-icon").click(function () {
            var $nav = $("nav");
            var navWidth = $nav.width();
            var $wrapper = $(".site-wrapper");
            TweenLite.to($nav, 0.5, { x: 0 });
            TweenLite.to($wrapper, 0.5, { x: navWidth });
        })

        $(".menu-close").click(function () {
            var $nav = $("nav");
            var navWidth = $nav.width();
            var $wrapper = $(".site-wrapper");
            TweenLite.to($nav, 0.5, { x: -navWidth });
            TweenLite.to($wrapper, 0.5, { x: 0 });
        })
    }
}