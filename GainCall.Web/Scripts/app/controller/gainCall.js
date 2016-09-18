/**
 * Created by Ghost on 9/11/2016.
 */
jQuery(function ($) {
    $('.field-input').focus(function () {
        $(this).parent().addClass('is-focused has-label');
    });

    $('.field-input').blur(function () {
        $parent = $(this).parent();
        if ($(this).val() == '') {
            $parent.removeClass('has-label');
        }
        $parent.removeClass('is-focused');
    });

});
jQuery(function ($) {
    $('.hide-password').on('click', function () {
        var $this = $(this),
            $password_field = $this.prev('input');

        ('password' == $password_field.attr('type')) ? $password_field.attr('type', 'text') : $password_field.attr('type', 'password');
        ('Hide' == $this.text()) ? $this.text('Show') : $this.text('Hide');
        //focus and move cursor to the end of input field
        $password_field.putCursorAtEnd();
    });

});

jQuery(document).ready(function ($) {
    /*var $switcher =  $('.switcher '),
     $form_profile_detail = $('#profile-detail'),
     $form_edit_profile = $('#edit-profile'),
     $form_profile_image = $('#profile-image'),
     $form_change_password = $('#change-password'),
     $tab_profile_detail = $switcher.children('li').eq(0).children('a'),
     $tab_edit_profile =  $switcher.children('li').eq(1).children('a'),
     $tab_profile_image =  $switcher.children('li').eq(2).children('a'),
     $tab_change_password = $switcher.children('li').eq(3).children('a');

     $switcher.on('click', function(event) {
     event.preventDefault();

     });*/

    $("#switcher li").click(function () {
        //  First remove class "active" from currently active tab
        $("#switcher li").removeClass('active');


        //  Now add class "active" to the selected/clicked tab
        $(this).addClass("active");

        //  Hide all tab content
        $(".st").removeClass('is-selected');

        //  Here we get the href value of the selected tab
        var selected_tab = $(this).find("a").attr("href");

        //  Show the selected tab content
        $(selected_tab).addClass('is-selected');

        //  At the end, we add return false so that the click on the link is not executed
        return false;
    });
});

jQuery(document).ready(function () {
    var $modal_load = $('.modal_container');
    var $modal_load_switcher = $modal_load.find('#switcher');
    var $modal_load_login = $modal_load.find('#login');
    var $modal_load_register = $modal_load.find('#register');
    var $modal_load_forget = $modal_load.find('#forget_password');
    var $modal_load_reset = $modal_load.find('#reset_password');
    $('#user_login').on('click', function () {
        $modal_load.addClass('is_visible');
        $modal_load_login.addClass('is-selected');
        $modal_load_forget.css('display', 'none');
        $modal_load_reset.css('display', 'none');
    });
    $('#user_register').on('click', function () {
        $modal_load.addClass('is_visible');
        $modal_load_switcher.find('li:nth-child(1)').removeClass('active');
        $modal_load_switcher.find('li:nth-child(2)').addClass('active');
        $modal_load_login.removeClass('is-selected');
        $modal_load_register.addClass('is-selected');
        $modal_load_forget.css('display', 'none');
        $modal_load_reset.css('display', 'none');
    });
    $('#forget-password').on('click', function () {
        $modal_load.addClass('is_visible');
        $modal_load_switcher.css('display', 'none');
        $modal_load_forget.css('display', 'block');
        $modal_load_reset.css('display', 'none');
    });
    $('#reset-password').on('click', function () {
        $modal_load.addClass('is_visible');
        $modal_load_switcher.css('display', 'none');
        $modal_load_forget.css('display', 'none');
        $modal_load_reset.css('display', 'block');
    });
});