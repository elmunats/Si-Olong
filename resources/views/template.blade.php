
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="{{ asset('assets/img/icon.png') }}">

    <title>Sistem Tolong Menolong (SIOLONG)</title>

    <!-- Bootstrap core CSS -->
     <link href="{{ asset('css/bootstrap.css') }} " rel="stylesheet" type="text/css"/>
       <script src="{{ asset('assets/plugins/bootstrap/css/bootstrap-hover-dropdown.min.css') }}" type="text/javascript"></script>
          <script src="{{ asset('assets/plugins/bootstrap/css/animate.min.css') }}" type="text/javascript"></script>
    <!-- Custom styles for this template -->
    <link href="{{ asset('css/navbar-fixed-top.css') }}" rel="stylesheet">

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <link href="{{ asset('assets/admin/production/fonts/css/font-awesome.min.css') }} " rel="stylesheet" type="text/css"/>
  <link href="{{ asset('assets/admin/production/css/animate.min.css') }} " rel="stylesheet" type="text/css"/>
  

  <!-- Custom styling plus plugins -->

  <link href="{{ asset('assets/admin/production/css/icheck/flat/green.css') }} " rel="stylesheet" type="text/css"/>
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
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
         
        </div>
        <div id="navbar" class="navbar-collapse collapse">
          <ul class="nav navbar-nav navbar-left">
           <li><img src="{{ asset('assets/img/Logo1.png') }}" alt="rounded image" class="img-rounded" width="150" height="50">  </li>
           </ul>
          <ul class="nav navbar-nav">
            <li class="active"><a href="#"><span class="glyphicon glyphicon-home" aria-hidden="true"></span> Home</a></li>
            <li class="dropdown">
              <a href="" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-th" aria-hidden="true"></span> Kategori</a>
              <ul class="dropdown-menu">

               <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Buku</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Buku Kuliah</a></li>
                              <li><a href="#">Komik</a></li>
                              <li><a href="#">Novel</a></li>
                              <li><a href="#">Majalah</a></li>
                              <li><a href="#">Kamus</a></li>
                               <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>

                <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Koleksi</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Aksesoris</a></li>
                              <li><a href="#">Mainan</a></li>
                              <li><a href="#">Alat Band</a></li>
                              <li><a href="#">Kerajinan</a></li>
                              <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>

                <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Fashion</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Baju</a></li>
                              <li><a href="#">Celana</a></li>
                              <li><a href="#">Kaos</a></li>
                              <li><a href="#">Sepatu</a></li>
                              <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>
                 <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Elektronik</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Alat Listrik</a></li>
                              <li><a href="#">Kamera</a></li>
                              <li><a href="#">Handicamp</a></li>
                              <li><a href="#">Radio dan Tape</a></li>
                             <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>

                 <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Komputer</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">PC</a></li>
                              <li><a href="#">Mouse</a></li>
                              <li><a href="#">Laptop</a></li>
                              <li><a href="#">Keyboard</a></li>
                              <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>
                                 
                    <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Perlengkapan Kantor</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Meja</a></li>
                              <li><a href="#">Bangku</a></li>
                              <li><a href="#">Papan</a></li>
                              <li><a href="#">Proyektor</a></li>
                              <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>

                <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Hobi</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Olahraga</a></li>
                              <li><a href="#">Melukis</a></li>
                              <li><a href="#">Naik Gunung</a></li>
                              <li><a href="#">Robotik</a></li>
                              <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>
                                 
                    <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Produk lain</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">Alat Rumah Tangga</a></li>
                              <li><a href="#">Perkakas Kendaraan</a></li>
                              <li><a href="#">Source Code Program</a></li>
                              <li><a href="#">Perlengkapan Jaringan</a></li>
                              <li><a href="#">Lain - lainnya</a></li>
                                            </ul>
                                        </li>
                                 


              </ul>
            </li>



                             <li class="dropdown">
              <a href="" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown"  role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></span> Transaksi</a>
              <ul class="dropdown-menu">
                 <li><a href="#">Konfirmasi Peminjaman</a></li>
                <li><a href="#">Status Peminjaman</a></li>
                <li><a href="#">COD</a></li>
                <li><a href="#">Konfirmasi Pengembalian</a></li>
                <li><a href="#">Komplain barang</a></li>
                
              </ul>
            </li>
              @if(Auth::user()=='admin')
               <li class="dropdown">
              <a href="" class="dropdown-toggle" data-toggle="dropdown" data-hover="dropdown"  role="button" aria-haspopup="true" aria-expanded="false"><span class="glyphicon glyphicon-calendar" aria-hidden="true"></span> Manage Data</a>
              <ul class="dropdown-menu">
                <li><a href="#">Halaman Admin</a></li>
                 <li class="dropdown-submenu">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Laporan</a>
                          <ul class="dropdown-menu">
                              <li><a href="#">PDF</a></li>
                              <li><a href="#">Excel</a></li>
                             
                                            </ul>
                                        </li>
                
              </ul>
            </li>
            @endif
                
           <li><a href="" data-toggle="modal" data-target="#myModal"><span class="glyphicon glyphicon-camera" aria-hidden="true"></span> Pinjamkan Barang</a></li>
            <li><form class="navbar-form " role="search">
        <div class="form-group">
          <input type="text" class="form-control" placeholder="Search">
        </div>
        <button type="submit" class="btn btn-default">Cari Barang</button></form>
              </li>
                  
          </ul>
   <ul class="nav navbar-nav navbar-right">
              <li class="">
                <a href="javascript:;" class="user-profile dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
                  <img src="{{ asset('assets/admin/production/images/img.jpg') }}" alt="">John Doe
                  <span class=" fa fa-angle-down"></span>
                </a>
                <ul class="dropdown-menu dropdown-usermenu animated fadeInDown pull-right">
                  <li><a href="javascript:;">  Profile</a>
                  </li>
                  <li>
                    <a href="javascript:;">
                      <span class="badge bg-red pull-right">50%</span>
                      <span>Settings</span>
                    </a>
                  </li>
                  <li>
                    <a href="javascript:;">Help</a>
                  </li>
                  <li><a href="login.html"><i class="fa fa-sign-out pull-right"></i> Log Out</a>
                  </li>
                </ul>
              </li>

              <li role="presentation" class="dropdown">
                <a href="javascript:;" class="dropdown-toggle info-number" data-toggle="dropdown" aria-expanded="false">
                  <i class="fa fa-envelope-o"></i>
                  <span class="badge bg-green">6</span>
                </a>
                <ul id="menu1" class="dropdown-menu list-unstyled msg_list animated fadeInDown" role="menu">
                  <li>
                    <a>
                      <span class="image">
                                        <img src="{{ asset('assets/admin/production/images/img.jpg') }}" alt="Profile Image" />
                                    </span>
                      <span>
                                        <span>John Smith</span>
                      <span class="time">3 mins ago</span>
                      </span>
                      <span class="message">
                                        Film festivals used to be do-or-die moments for movie makers. They were where...
                                    </span>
                    </a>
                  </li>
                  <li>
                    <a>
                      <span class="image">
                                        <img src="{{ asset('assets/admin/production/images/img.jpg') }}" alt="Profile Image" />
                                    </span>
                      <span>
                                        <span>John Smith</span>
                      <span class="time">3 mins ago</span>
                      </span>
                      <span class="message">
                                        Film festivals used to be do-or-die moments for movie makers. They were where...
                                    </span>
                    </a>
                  </li>
                  <li>
                    <a>
                      <span class="image">
                                        <img src="{{ asset('assets/admin/production/images/img.jpg') }}" alt="Profile Image" />
                                    </span>
                      <span>
                                        <span>John Smith</span>
                      <span class="time">3 mins ago</span>
                      </span>
                      <span class="message">
                                        Film festivals used to be do-or-die moments for movie makers. They were where...
                                    </span>
                    </a>
                  </li>
                  <li>
                    <a>
                      <span class="image">
                                        <img src="{{ asset('assets/admin/production/images/img.jpg') }}" alt="Profile Image" />
                                    </span>
                      <span>
                                        <span>John Smith</span>
                      <span class="time">3 mins ago</span>
                      </span>
                      <span class="message">
                                        Film festivals used to be do-or-die moments for movie makers. They were where...
                                    </span>
                    </a>
                  </li>
                  <li>
                    <div class="text-center">
                      <a>
                        <strong>See All Alerts</strong>
                        <i class="fa fa-angle-right"></i>
                      </a>
                    </div>
                  </li>
                </ul>
              </li>

            </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>
            <!-- Modal -->
          <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog modal-lg">
              <div class="modal-content">
                <div class="modal-header">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h4 class="modal-title">Form Pinjamkan Barang</h4>
                </div>
                <div class="modal-body">
                    <p>Masukkan deskripsi barang yang akan dipinjamkan</p>
                      <div class="row">
                        <div class="col-sm-4">
                          <form role="form">
                          <div class="form-group">
                            <label for="usr">Nama Barang</label>
                            <input type="text" class="form-control" >
                          </div>
                          <div class="form-group">
                            <label for="pwd">Banyak Barang</label>
                            <input type="text" class="form-control" >
                          </div>
                          </form>
                        </div>
                        <div class="col-sm-4">
                          <form role="form">
                          <div class="form-group">
                            <label for="usr">Berat Barang</label>
                            <input type="text" class="form-control" >
                          </div>
                          <div class="form-group">
                            <label for="pwd">Kondisi Barang</label>
                            <input type="text" class="form-control" >
                          </div>
                          </form>
                        </div>
                        <div class="col-sm-4">
                          <form role="form">
                          <div class="form-group">
                            <label for="usr">upload foto barang</label>
                            <button type="button" class="btn btn-default" >Upload</button>
                          </div>
                          </form>
                        </div>
                      </div>
                      <form role="form">
                        <div class="form-group">
                          <label for="usr">Deskripsi Barang</label>
                           <textarea class="form-control" rows="10" id="comment"></textarea>
                        </div>
                      
                        
                      </form>

                </div>
                <div class="modal-footer">
                  <button type="button" class="btn btn-default" >Posting</button>
                </div>
              </div>
            </div>
          </div>


    @yield('content')

     <!-- /container -->
<div class="container well">
    <div class="row">
      <div class="col-xs-6 col-sm-6 col-md-6 col-lg-4">
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
     <script src="{{ asset('assets/plugins/jquery-1.10.1.min.js') }}" type="text/javascript"></script>
     <script src="{{ asset('js/bootstrap.js') }}" type="text/javascript"></script>
      <script src="{{ asset('assets/plugins/bootstrap/js/bootstrap-hover-dropdown.js') }}" type="text/javascript"></script>
      <script type="text/javascript">
        

      </script>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="{{ asset('js/ie10-viewport-bug-workaround.js') }}"></script>
  </body>
</html>
