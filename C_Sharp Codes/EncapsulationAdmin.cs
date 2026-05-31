using System;
using System.Collections.Generic;
using System.Text;


     class EncapsulationAdmin
    {

    private int adminid;
        private string adminpassword;


    public void getadminidAndpassword(int adminid,string adminpasword)
    {
        this.adminid = adminid;//store int parameter in instance variable
        this.adminpassword = adminpasword;//store string parameter in instance variable
    }
    public int setadminid()// this is adminid return method
    {
        return adminid;
    }
    public string setadminpassword()//this is adminpassword return method
    {
        return adminpassword;
    }
    
    static void Main(string[] args)
    {
        EncapsulationAdmin a = new EncapsulationAdmin();
        a.getadminidAndpassword(102,"admin@123");//calling parameterise method

        Console.WriteLine("adminid is: "+a.setadminid());//calling return type adminid method
        Console.WriteLine("adminpassword is:"+a.setadminpassword());//calling return type adminpassword method

    }
}

