<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!--> <html lang="en"> <!--<![endif]-->
<!-- BEGIN HEAD -->
<head>
    <meta charset="utf-8" />
    <title>Register Form</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <meta content="" name="description" />
    <meta content="" name="author" />
    <!-- BEGIN GLOBAL MANDATORY STYLES -->
    <link href="{{ asset('assets/plugins/bootstrap/css/bootstrap.min.css') }} " rel="stylesheet" type="text/css"/>
    <link href="{{ asset('assets/plugins/bootstrap/css/bootstrap-responsive.min.css') }} " rel="stylesheet" type="text/css"/>
    <link href="{{ asset('assets/plugins/font-awesome/css/font-awesome.min.css') }} " rel="stylesheet" type="text/css"/>
    <link href="{{ asset('assets/css/style-metro.css') }} " rel="stylesheet" type="text/css"/>
    <link href="{{ asset('assets/css/style.css') }} " rel="stylesheet" type="text/css"/>
    <link href="{{ asset('assets/css/style-responsive.css') }} " rel="stylesheet" type="text/css"/>
    <link href="{{ asset('assets/css/themes/default.css') }} " rel="stylesheet" type="text/css" id="style_color"/>
    <link href="{{ asset('assets/plugins/uniform/css/uniform.default.css') }} " rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="{{ asset('assets/plugins/select2/select2_metro.css') }} " />
    <!-- END GLOBAL MANDATORY STYLES -->
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link href="{{ asset('assets/css/pages/login-soft.css') }} " rel="stylesheet" type="text/css"/>
    <!-- END PAGE LEVEL STYLES -->
    <link rel="shortcut icon" href="favicon.ico" />
       @stack('scripts')
</head>
<!-- END HEAD -->
<!-- BEGIN BODY -->
<body class="login">
    <!-- BEGIN LOGO -->
    <div class="logo">
        <!-- PUT YOUR LOGO HERE -->
        <img src="{{ asset('assets/img/logo.png') }}" width="200" height="150" alt=""/> </div>
        <!-- PUT YOUR LOGO HERE -->
    </div>
    <!-- END LOGO -->
      <div class="content">
             <!-- BEGIN FORGOT PASSWORD FORM -->
        <form class="form-vertical forget-form" action="index.html" method="post">
            <h3 >Forget Password ?</h3>
            <p>Enter your e-mail address below to reset your password.</p>
            <div class="control-group">
                <div class="controls">
                    <div class="input-icon left">
                        <i class="icon-envelope"></i>
                        <input class="m-wrap placeholder-no-fix" type="text" placeholder="Email" autocomplete="off" name="email" />
                    </div>
                </div>
            </div>
            <div class="form-actions">
                <button type="button" id="back-btn" class="btn">
                <i class="m-icon-swapleft"></i> Back
                </button>
                <button type="submit" class="btn blue pull-right">
                Submit <i class="m-icon-swapright m-icon-white"></i>
                </button>            
            </div>
        </form>
        <!-- END FORGOT PASSWORD FORM -->
       
    </div>
    <!-- END LOGIN -->
    <!-- BEGIN COPYRIGHT -->
    <div class="copyright">
        2016 &copy; siOlong Register Form
    </div>
    <!-- END COPYRIGHT -->
    <!-- BEGIN JAVASCRIPTS(Load javascripts at bottom, this will reduce page load time) -->
    <!-- BEGIN CORE PLUGINS -->   <script src="{{ asset('assets/plugins/jquery-1.10.1.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('assets/plugins/jquery-migrate-1.2.1.min.js') }}" type="text/javascript"></script>
    <!-- IMPORTANT! Load jquery-ui-1.10.1.custom.min.js before bootstrap.min.js to fix bootstrap tooltip conflict with jquery ui tooltip -->
    <script src="{{ asset('assets/plugins/jquery-ui/jquery-ui-1.10.1.custom.min.js') }}" type="text/javascript"></script>      
    <script src="{{ asset('assets/plugins/bootstrap/js/bootstrap.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('assets/plugins/bootstrap-hover-dropdown/twitter-bootstrap-hover-dropdown.min.js') }}" type="text/javascript" ></script>
    <!--[if lt IE 9]>
    <script src="{{ asset('assets/plugins/excanvas.min.js') }}"></script>
    <script src="{{ asset('assets/plugins/respond.min.js') }}"></script>  
    <script src="{{ asset('assets/scripts/login-soft.js') }}" type="text/javascript"></script> 
    <![endif]-->   
    <script src="{{ asset('assets/plugins/jquery-slimscroll/jquery.slimscroll.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('assets/plugins/jquery.blockui.min.js') }}" type="text/javascript"></script>  
    <script src="{{ asset('assets/plugins/jquery.cookie.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('assets/plugins/uniform/jquery.uniform.min.js') }}" type="text/javascript" ></script>
    <!-- END CORE PLUGINS -->
    <!-- BEGIN PAGE LEVEL PLUGINS -->
    <script src="{{ asset('assets/plugins/jquery-validation/dist/jquery.validate.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('assets/plugins/backstretch/jquery.backstretch.min.js') }}" type="text/javascript"></script>
    <script type="text/javascript" src="{{ asset('assets/plugins/select2/select2.min.js') }}"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="{{ asset('assets/scripts/app.js') }}" type="text/javascript"></script>
  
    <!-- END PAGE LEVEL SCRIPTS --> 
    <script>
        jQuery(document).ready(function() {     
          App.init();
          Login.init();
        });
    </script>
    <script >
      $.backstretch([
             "{{ asset('assets/bg/1.jpg') }}",
              "{{ asset('assets/bg/2.jpg') }}",
               "{{ asset('assets/bg/3.jpg') }}",
               "{{ asset('assets/bg/4.jpg') }}"
                ], {
                  fade: 1000,
                  duration: 8000
            });
  
       
    </script>
   
  {{ Html::script('assets/scripts/login-soft.js') }} 
    <!-- END JAVASCRIPTS -->
   
</body>
<!-- END BODY -->
</html>