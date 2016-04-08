<?php

namespace App\Http\Controllers;

use App\UserUbah;
use Request;
//use Illuminate\Support\Facades\Request;
use App\Http\Requests;

class UbahUserController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
         $id= UserUbah::where('id','=','email')->first();
       // $UbahUser = User::all();
        //return View('password/reset',compact('UbahUser'));
         $UbahUser=UserUbah::find($id);
   return view('password.reset.index',compact('UbahUser'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit()
    {
    $UbahUser=UserUbah::find($id);
   return view('password.reset.edit',compact('UbahUser'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    $UbahUpdate=Request::all();
   $UbahUser=UserUbah::find($id);
   $UbahUser->update($UbahUpdate);
   return redirect('/');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
