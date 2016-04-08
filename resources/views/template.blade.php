
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="../../favicon.ico">

    <title>Sistem Tolong Menolong (SIOLONG)</title>

    <!-- Bootstrap core CSS -->
    <link href="{{ asset('css/bootstrap.css') }}" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="{{ asset('css/navbar-fixed-top.css') }}" rel="stylesheet">

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>

  <body>

    <!-- Fixed navbar -->
    <nav class="navbar navbar-default navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#"><span class="glyphicon glyphicon-btc" aria-hidden="true"></span> SioLong</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
          <ul class="nav navbar-nav">
            <li class="active"><a href="#"><span class="glyphicon glyphicon-home" aria-hidden="true"></span> Home</a></li>
            <li class="dropdown">
              <a href="" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-th" aria-hidden="true"></span> Kategori</a>
              <ul class="dropdown-menu">
                <li><a href="#">Pakaian</a></li>
                <li><a href="#">Buku</a></li>
                <li><a href="#">Gadget</a></li>
                <li><a href="#">Elektronik</a></li>
                <li><a href="#">Software</a></li>
                <li><a href="#">Hardware</a></li>
                <li><a href="#">Produk lain</a></li>
              </ul>
            </li>
             <li class="dropdown">
              <a href="" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></span> Transaksi</a>
              <ul class="dropdown-menu">
                <li><a href="#">COD</a></li>
                <li><a href="#">Transfer</a></li>
                <li><a href="#">Credit</a></li>
                <li><a href="#">Gadai barang</a></li>
                <li><a href="#">Transaksi lain</a></li>
              </ul>
            </li>
           <li><a href="#about"><span class="glyphicon glyphicon-calendar" aria-hidden="true"></span> Laporan</a></li>
           <li><a href="#about"><span class="glyphicon glyphicon-camera" aria-hidden="true"></span> Pinjamkan Barang</a></li>
            <li><form class="navbar-form " role="search">
        <div class="form-group">
          <input type="text" class="form-control" placeholder="Search">
        </div>
        <button type="submit" class="btn btn-default">Cari Barang</button></form>
              </li>
          </ul>
 
          <ul class="nav navbar-nav navbar-right">
         <li class="dropdown">
         @if(Auth::guest())
              <a href="" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-user" aria-hidden="true"></span> User </a>
              <ul class="dropdown-menu">
          
                <li><a href="{{ url('auth/login') }}"><span class="glyphicon glyphicon-log-in" aria-hidden="true"></span> Login</a></li>
               @else
      <a href="" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-user" aria-hidden="true"></span>Halo, {{Auth::user()->name}} </a>
              <ul class="dropdown-menu">
           <li><a href="{{ url('auth/logout') }}"><span class="glyphicon glyphicon-log-out" aria-hidden="true"></span> Logout </a></li>
           @endif
          
                 <li><a href="#about"><span class="glyphicon glyphicon-gift" aria-hidden="true"></span> Reward</a></li>
             <li><a href="#about"><span class="glyphicon glyphicon-cog" aria-hidden="true"></span> Setting</a></li>
           
              </ul>
            </li>
            
      
            
          </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>



    @yield('content')

     <!-- /container -->
<div class="container well">
    <div class="row">
      <div class="col-xs-6 col-sm-6 col-md-6 col-lg-7">
        <div class="row">
          <div class="col-sm-4 col-md-4 col-lg-4 col-xs-6">
            <div>
            <h4>SiOlong</h4>
              <ul class="list-unstyled">
                <li> <a href="#">Tentang kami</a> </li>
                <li> <a href="#">Karir</a> </li>
                <li> <a href="#">Kegiatan Kami</a> </li>
              </ul>
            </div>
          </div>
          <div class="col-sm-4 col-md-4 col-lg-4  col-xs-6">
            <div>            
            <h4>Meminjam</h4>
              <ul class="list-unstyled">
                <li> <a href="#">Pinjam di SiOlong</a> </li>
                <li> <a href="#">Cara meminjam</a> </li>
                <li> <a href="#">Pembayaran</a> </li>
              </ul>
            </div>
          </div>
          <div class="col-sm-4 col-md-4 col-lg-4 col-xs-6">
            <div>
            <h4>Meminjamkan</h4>
              <ul class="list-unstyled">
                <li> <a href="#">Meminjamkan di SiOlong</a> </li>
                <li> <a href="#">Cara meminjamkan</a> </li>
                <li> <a href="#">Reward</a> </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
      <div class="col-sm-4 col-md-4 col-lg-4  col-xs-6">
        <div>            
        <h4>Bantuan</h4>
          <ul class="list-unstyled">
            <li> <a href="#">Syarat & Ketentuan</a> </li>
            <li> <a href="#">Kebijakan privasi</a> </li>
            <li> <a href="#">Hubungi kami</a> </li>
          </ul>
        </div>
      </div>
      <!--
      <div class="col-xs-6 col-sm-4 col-md-4 col-lg-4"> 
        <address>
        <strong>SiOlong, Inc.</strong><br>
        Jl. Lenteng Agung Raya No.20<br>
        Jakarta Selatan 12640<br>
        <abbr title="Contact">Contact:</abbr> 0878-8826-2825
      </address>
        <address>
        <strong>SiOlong</strong><br>
        <a href="mailto:#">siolong@gmail.com</a>
        </address>
        </div>
    </div>
    -->
  </div>

<footer class="text-center">
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <p>Copyright © Si Olong. All rights reserved.</p>
      </div>
    </div>
  </div>
</footer>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script> 
    <script src="{{ asset('js/bootstrap.min.js') }}"></script>
     <script src="{{ asset('js/jquery.min.js') }}"></script>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="{{ asset('js/ie10-viewport-bug-workaround.js') }}"></script>
  </body>
</html>
