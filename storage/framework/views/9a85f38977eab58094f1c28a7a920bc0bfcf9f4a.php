<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!--> <html lang="en"> <!--<![endif]-->
<!-- BEGIN HEAD -->
<head>
    <meta charset="utf-8" />
    <title>Login Form</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <meta content="" name="description" />
    <meta content="" name="author" />
    <!-- BEGIN GLOBAL MANDATORY STYLES -->
    <link href="<?php echo e(asset('assets/plugins/bootstrap/css/bootstrap.min.css')); ?> " rel="stylesheet" type="text/css"/>
    <link href="<?php echo e(asset('assets/plugins/bootstrap/css/bootstrap-responsive.min.css')); ?> " rel="stylesheet" type="text/css"/>
    <link href="<?php echo e(asset('assets/plugins/font-awesome/css/font-awesome.min.css')); ?> " rel="stylesheet" type="text/css"/>
    <link href="<?php echo e(asset('assets/css/style-metro.css')); ?> " rel="stylesheet" type="text/css"/>
    <link href="<?php echo e(asset('assets/css/style.css')); ?> " rel="stylesheet" type="text/css"/>
    <link href="<?php echo e(asset('assets/css/style-responsive.css')); ?> " rel="stylesheet" type="text/css"/>
    <link href="<?php echo e(asset('assets/css/themes/default.css')); ?> " rel="stylesheet" type="text/css" id="style_color"/>
    <link href="<?php echo e(asset('assets/plugins/uniform/css/uniform.default.css')); ?> " rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="<?php echo e(asset('assets/plugins/select2/select2_metro.css')); ?> " />
    <!-- END GLOBAL MANDATORY STYLES -->
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link href="<?php echo e(asset('assets/css/pages/login-soft.css')); ?> " rel="stylesheet" type="text/css"/>
    <!-- END PAGE LEVEL STYLES -->
    <link rel="shortcut icon" href="favicon.ico" />
      
<!-- END HEAD -->
<!-- BEGIN BODY -->
<body class="login">
    <!-- BEGIN LOGO -->
    <div class="logo">
<img src="<?php echo e(asset('assets/img/logo.png')); ?>" width="200" height="150" alt=""/> </div>
        <!-- PUT YOUR LOGO HERE -->
    </div>
    <!-- END LOGO -->
    <!-- BEGIN LOGIN -->
    <div class="content">
        <!-- BEGIN LOGIN FORM -->
        <form class="form-vertical login-form" action="<?php echo e(url('auth/login')); ?>" method="post">
        <?php echo csrf_field(); ?>

            <h3 class="form-title">Login to your account</h3>
            <div class="alert alert-error hide">
                <button class="close" data-dismiss="alert"></button>
                <span>Enter any username and password.</span>
            </div>
            <div class="control-group">
                <!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
                <label class="control-label visible-ie8 visible-ie9">Username</label>
                <div class="controls">
                    <div class="input-icon left">
                        <i class="icon-user"></i>
                        <input class="m-wrap placeholder-no-fix" type="text" autocomplete="off" placeholder="Username" name="username" />
                    </div>
                </div>
            </div>
            <div class="control-group">
                <label class="control-label visible-ie8 visible-ie9">Password</label>
                <div class="controls">
                    <div class="input-icon left">
                        <i class="icon-lock"></i>
                        <input class="m-wrap placeholder-no-fix" type="password" autocomplete="off" placeholder="Password" name="password"/>
                    </div>
                </div>
            </div>
            <div class="form-actions">
                <label class="checkbox">
                <input type="checkbox" name="remember" value="1"/> Remember me
                </label>
                <button type="submit" class="btn blue pull-right">
                Login <i class="m-icon-swapright m-icon-white"></i>
                </button>            
            </div>
            <div class="forget-password">
                <h4>Forgot your password ?</h4>
                <p>
                    no worries, click  <?php echo link_to('auth/reset','Create an account',array('javascript:;','id'=>'register-btn')); ?><a href="javascript:;"  id="forget-password">here</a>
                    to reset your password.
                </p>
            </div>
            <div class="create-account">
                <p>
                    Don't have an account yet ?&nbsp; 
                    <?php echo link_to('auth/register','Create an account',array('javascript:;','id'=>'register-btn')); ?>

                
                </p>
            </div>
        </form>
        <!-- END LOGIN FORM -->        
        </div>
       
    <!-- BEGIN COPYRIGHT -->
    <div class="copyright">
        2016 &copy; siOlong  Login Form
    </div>
    <!-- END COPYRIGHT -->
    <!-- BEGIN JAVASCRIPTS(Load javascripts at bottom, this will reduce page load time) -->
    <!-- BEGIN CORE PLUGINS -->   <script src="<?php echo e(asset('assets/plugins/jquery-1.10.1.min.js')); ?>" type="text/javascript"></script>
    <script src="<?php echo e(asset('assets/plugins/jquery-migrate-1.2.1.min.js')); ?>" type="text/javascript"></script>
    <!-- IMPORTANT! Load jquery-ui-1.10.1.custom.min.js before bootstrap.min.js to fix bootstrap tooltip conflict with jquery ui tooltip -->
    <script src="<?php echo e(asset('assets/plugins/jquery-ui/jquery-ui-1.10.1.custom.min.js')); ?>" type="text/javascript"></script>      
    <script src="<?php echo e(asset('assets/plugins/bootstrap/js/bootstrap.min.js')); ?>" type="text/javascript"></script>
    <script src="<?php echo e(asset('assets/plugins/bootstrap-hover-dropdown/twitter-bootstrap-hover-dropdown.min.js')); ?>" type="text/javascript" ></script>
    <!--[if lt IE 9]>
    <script src="<?php echo e(asset('assets/plugins/excanvas.min.js')); ?>"></script>
    <script src="<?php echo e(asset('assets/plugins/respond.min.js')); ?>"></script>  
    <script src="<?php echo e(asset('assets/scripts/login-soft.js')); ?>" type="text/javascript"></script> 
    <![endif]-->   
    <script src="<?php echo e(asset('assets/plugins/jquery-slimscroll/jquery.slimscroll.min.js')); ?>" type="text/javascript"></script>
    <script src="<?php echo e(asset('assets/plugins/jquery.blockui.min.js')); ?>" type="text/javascript"></script>  
    <script src="<?php echo e(asset('assets/plugins/jquery.cookie.min.js')); ?>" type="text/javascript"></script>
    <script src="<?php echo e(asset('assets/plugins/uniform/jquery.uniform.min.js')); ?>" type="text/javascript" ></script>
    <!-- END CORE PLUGINS -->
    <!-- BEGIN PAGE LEVEL PLUGINS -->
    <script src="<?php echo e(asset('assets/plugins/jquery-validation/dist/jquery.validate.min.js')); ?>" type="text/javascript"></script>
    <script src="<?php echo e(asset('assets/plugins/backstretch/jquery.backstretch.min.js')); ?>" type="text/javascript"></script>
    <script type="text/javascript" src="<?php echo e(asset('assets/plugins/select2/select2.min.js')); ?>"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="<?php echo e(asset('assets/scripts/app.js')); ?>" type="text/javascript"></script>
  
    <!-- END PAGE LEVEL SCRIPTS --> 
    <script>
        jQuery(document).ready(function() {     
          App.init();
          Login.init();
        });
    </script>
    <script >
      $.backstretch([
             "<?php echo e(asset('assets/bg/1.jpg')); ?>",
              "<?php echo e(asset('assets/bg/2.jpg')); ?>",
               "<?php echo e(asset('assets/bg/3.jpg')); ?>",
               "<?php echo e(asset('assets/bg/4.jpg')); ?>"
                ], {
                  fade: 1000,
                  duration: 8000
            });
  
       
    </script>
   
  <?php echo e(Html::script('assets/scripts/login-soft.js')); ?> 
    <!-- END JAVASCRIPTS -->
   
</body>
<!-- END BODY -->
</html>