using System;
using System.Collections;
using System.Data;
using Chloe;
using Chloe.SqlServer;
using Chloe.Annotations;
using System.Windows.Forms;
using 预约系统2._0;
using chloe_control_namespace;
using System.Linq;
using System.Collections.Generic;

namespace chloe_control_namespace
{
    //用户登录表

    [Table("Login")]
    public class Login
    {
        [ColumnAttribute("UserName", IsPrimaryKey = true)]
        public String UserName { get; set; }
        public String Password { get; set; }
        public String RealName { get; set; }
        public String Tel { get; set; }
    }

    //用户标记表

    [Table("User_BJ")]
    public class User_BJ
    {
        [ColumnAttribute("UserName", IsPrimaryKey = true)]
        public String UserName { get; set; }
        public int Permissions { get; set; }
        public int BreakTime { get; set; }
        public String Forbid { get; set; }
        public String Award { get; set; }
        public String BreakBJ { get; set; }
    }

    //用户建议表

    [Table("YH_Suggest")]

    public class YH_Suggest
    {
        [ColumnAttribute("UserName", IsPrimaryKey = true)]

        public String UserName { get; set; }

        public String NeiRong { get; set; }

        public DateTime WriteTime { get; set; }
    }

    //用户举报表

    [Table("YH_JuBao")]

    public class YH_JuBao
    {
        [ColumnAttribute("UserName", IsPrimaryKey = true)]

        public String UserName { get; set; }

        public String NeiRong { get; set; }

        public DateTime WriteTime { get; set; }
    }

    //场地信息表

    [Table("Yard")]

    public class Yard
    {
        [ColumnAttribute("YardID", IsPrimaryKey = true)]

        public String YardID { get; set; }

        public String YardNameID { get; set; }

        public String YardAddressID { get; set; }

        public String OpenTime { get; set; }

        public double Price { get; set; }

    }

    //系统通知表

    [Table("SystemContent")]
    public class SystemContent
    {
        [ColumnAttribute("NoteID", IsPrimaryKey = true)]
        public int NoteID { get; set; }

        public String Title { get; set; }

        public String Information { get; set; }

        public DateTime NoteTime { get; set; }
    }

    //场地通知表

    [Table("YardContent")]
    public class YardContent
    {
        [ColumnAttribute("NoteID", IsPrimaryKey = true)]
        public int NoteID { get; set; }

        public String Title { get; set; }

        public String Information { get; set; }

        public DateTime NoteTime { get; set; }
    }

    //公告栏表

    [Table("GGContent")]
    public class GGContent
    {
        [ColumnAttribute("NoteID", IsPrimaryKey = true)]
        public int NoteID { get; set; }

        public String Title { get; set; }

        public String Information { get; set; }

        public DateTime NoteTime { get; set; }
    }

    //黑名单表

    [Table("HMD")]
    public class HMD
    {
        [ColumnAttribute("UserName", IsPrimaryKey = true)]
        public String UserName { get; set; }

        public String RealName { get; set; }

    }

    //预订信息表
    [Table("Booking")]
    public class Booking
    {
        [ColumnAttribute("Book_personid", IsPrimaryKey = true)]
        public String Book_personid { get; set; }
        public String Book_person { get; set; }
        public String yARDID { get; set; }
        public String OpenTime { get; set; }
        public String CloseTime { get; set; }
        public String BookDate { get; set; }
        public DateTime REALDate { get; set; }
        public String Tel { get; set; }
        public String BookCondition { get; set; }
    }

    //支付信息表
    [Table("PAY")]
    public class PAY
    {
        [ColumnAttribute("payid", IsPrimaryKey = true)]
        public String payid { get; set; }
        public String payname { get; set; }
        public String yardid { get; set; }
        public String begintime { get; set; }
        public String overtime { get; set; }
        public String booktime { get; set; }
        public string realTIME { get; set; }
        public String paymoney { get; set; }
        public DateTime paytime { get; set; }
    }
}

    public class chloe_control_all
    {
        protected IDbContext chloe_connect;
        public chloe_control_all(String connect_str)
        {
            chloe_connect = new MsSqlContext(connect_str);
        }

    //管理员——用户注册_用户名查重

    public int user_find(String User_yonghuming)
    {
        Login find_result = new Login();
        IQuery<Login> find_query = chloe_connect.Query<Login>();
        find_result = find_query.Where(b => b.UserName == User_yonghuming).FirstOrDefault();
        if (find_result == null)
        {
            return 0;
        }
        else if(find_result !=null)
        {
            return 1;
        }
        return -1;
    }

    //用户——用户注册_用户名查重
    public int username_find(String User_yonghu)
    {
        Login userfind_result = new Login();
        IQuery<Login> find_query = chloe_connect.Query<Login>();
        userfind_result = find_query.Where(b => b.UserName == User_yonghu).FirstOrDefault();
        if (userfind_result == null)
        {
            return 0;
        }
        else if (userfind_result != null)
        {
            return 1;
        }
        return -1;
    }


    //登录检测
    public int login_check(String User_id, String User_password)
    {
        Login user_result = new Login();
        IQuery<Login> user_check_query = chloe_connect.Query<Login>();
        user_result = user_check_query.Where(a => a.UserName == User_id).Where(a => a.Password == User_password).FirstOrDefault();
        if (user_result == null)
        {
            return 0;
        }
        else//判断用户权限，实现跳转页面   //判断用户是否为禁用用户
        {
            User_BJ user_permissons = new User_BJ();

            User_BJ user_forbid = new User_BJ();

            IQuery<User_BJ> user_permissions_check_query = chloe_connect.Query<User_BJ>();

            IQuery<User_BJ> user_forbid_check = chloe_connect.Query<User_BJ>();

            user_permissons = user_permissions_check_query.Where(a => a.UserName == User_id).FirstOrDefault();     
            
            user_forbid = user_forbid_check.Where(a => a.UserName == User_id).FirstOrDefault();

            if (user_forbid.Forbid.ToString() == "YES")
            {
                return 3;
            }
            else
            {            
                 if (user_permissons.Permissions == 1)
               { 
                         return 1;
               }
                 else
               {
                         return 2;
               }  
            }
        }
    }

    //管理员——用户信息查找（查找指定用户）

    public List<User_BJ> User_Search(String search_model)//String search_info)//int BREAKTIME, String FORBID, String AWARD, String BREAKBJ)
    {
        User_BJ usersearch = new User_BJ();
        IQuery<User_BJ> usersearch_query = chloe_connect.Query<User_BJ>();
        List<User_BJ> user_list = new List<User_BJ>();       
        switch (search_model)
        {
            case "查找普通用户":
                user_list = usersearch_query.Where(a => a.Permissions == 2).ToList();
                break;                
            case "查找违约用户":
                user_list = usersearch_query.Where(a => a.BreakBJ.Contains("YES")).ToList();
                break;
            case "查找禁用用户":
                user_list = usersearch_query.Where(a => a.Forbid.Contains("YES")).ToList();
                break;
            case "查找奖励用户":
                user_list = usersearch_query.Where(a => a.Award.Contains("YES")).ToList();
                break;
            case "查找违约次数为3的用户":
                user_list = usersearch_query.Where(a => a.BreakTime == 3).ToList();
                break;                
        }
        return user_list;
    }

    //用户——取消预约（新）

    public List<Booking> person_search(String id)
    {
        Booking personsearch = new Booking();
        IQuery<Booking> personsearch_query = chloe_connect.Query<Booking>();
        List<Booking> person_list = new List<Booking>();
        person_list = personsearch_query.Where(a => a.Book_personid == id).ToList();
        return person_list;
    }

    //管理员——用户注册(表Login)
        public bool insert_user1(String username, String password, String realname, String tel)
        {
            try
            {
                Login user_to_insert = new Login();
                user_to_insert.UserName = username;
                user_to_insert.Password = password;
                user_to_insert.RealName = realname;
                user_to_insert.Tel = tel;
                chloe_connect.Insert(user_to_insert);
                MessageBox.Show("注册成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("注册失败！");
                return false;
            }
        }

    //管理员——用户注册（表User_BJ）
    public bool insert_user2(String username,int per)
    {
        try
        {
            User_BJ userBJ_to_insert = new User_BJ();
            userBJ_to_insert.UserName = username;
            userBJ_to_insert.Permissions = per;
            userBJ_to_insert.Award = "NO";
            userBJ_to_insert.BreakBJ = "NO";
            userBJ_to_insert.BreakTime = 0;
            userBJ_to_insert.Forbid = "NO";
            chloe_connect.Insert(userBJ_to_insert);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    //用户——用户注册（表Login）
    public bool YH_insert_user1(String username, String password, String realname, String tel)
    {
        try
        {
            Login YH_insert1 = new Login();
            YH_insert1.UserName = username;
            YH_insert1.Password = password;
            YH_insert1.RealName = realname;
            YH_insert1.Tel = tel;
            chloe_connect.Insert(YH_insert1);
            MessageBox.Show("注册成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("注册失败！");
            return false;
        }
    }

    //用户——用户注册（表User_BJ）
    public bool YH_insert_user2(String username)//String forbid,String award,String breakbj,int breaktime,int permissions
    {
        try
        {
            User_BJ YH_insert2 = new User_BJ();
            YH_insert2.UserName = username;
            YH_insert2.Permissions = 2;
            YH_insert2.Award = "NO";
            YH_insert2.BreakBJ = "NO";
            YH_insert2.BreakTime = 0;
            YH_insert2.Forbid = "NO";
            chloe_connect.Insert(YH_insert2);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    //用户——提交建议信息
    public bool inser_suggest(String neirong,DateTime writetime)
        {
            Start st = new Start();
            String aa = Start.CUser;
            try
            {
                YH_Suggest suggest_to_insert = new YH_Suggest();
                suggest_to_insert.UserName = aa;
                suggest_to_insert.NeiRong = neirong;
                suggest_to_insert.WriteTime = DateTime.Now;
                chloe_connect.Insert(suggest_to_insert);
                MessageBox.Show("提交成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("提交失败！");
                return false;
            }
        }

    //用户——提交举报信息

        public bool inser_jubao(String neirong, DateTime writetime)
        {
            Start ts = new Start();
            String bb = Start.CUser;
            try
            {
                YH_JuBao jubao_to_insert = new YH_JuBao();
                jubao_to_insert.UserName = bb;
                jubao_to_insert.NeiRong = neirong;
                jubao_to_insert.WriteTime = DateTime.Now;
                chloe_connect.Insert(jubao_to_insert);
                MessageBox.Show("提交成功!");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("提交失败！");
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    //管理员——录入场地信息

        public bool insert_yard(String yardid, String yardnameid, String yardaddressid, String opentime, int price)
        {
            try
            {
                Yard yard_to_insert = new Yard();
                yard_to_insert.YardID = yardid;
                yard_to_insert.YardNameID = yardnameid;
                yard_to_insert.YardAddressID = yardaddressid;
                yard_to_insert.OpenTime = opentime;
                yard_to_insert.Price = price;
                chloe_connect.Insert(yard_to_insert);
                MessageBox.Show("录入成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("录入失败！");
                return false;
            }
        }

    //管理员——修改场地信息

    public bool Yard_XG(String ID_Yard, String NameID_Yard, String AddressID_Yard, String Time_Open,int Price_Yard)
    {
        try
        {
            Yard Yard_xg = new Yard();
            Yard_xg.YardID = ID_Yard;
            Yard_xg.YardNameID = NameID_Yard;
            Yard_xg.YardAddressID = AddressID_Yard;
            Yard_xg.OpenTime = Time_Open;
            Yard_xg.Price = Price_Yard;
            chloe_connect.Update<Yard>(Yard_xg);
            MessageBox.Show("修改成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("修改失败！");
            return false;
        }
    }

    //管理员——录入系统通知

    public bool inser_systemcontent(int noteid,String title,String information, DateTime notetime)
        {
            try
            {
                SystemContent systemcontent_to_insert = new SystemContent();
                systemcontent_to_insert.NoteID = noteid;
                systemcontent_to_insert.Title = title;
                systemcontent_to_insert.Information = information;
                systemcontent_to_insert.NoteTime = DateTime.Now;
                chloe_connect.Insert(systemcontent_to_insert);
                MessageBox.Show("录入成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("录入失败！");
                return false;
            }
        }

    //管理员——录入场地通知

        public bool inser_yardcontent(int noteid, String title, String information, DateTime notetime)
        {
            try
            {
                YardContent yardcontent_to_insert = new YardContent();
                yardcontent_to_insert.NoteID = noteid;
                yardcontent_to_insert.Title = title;
                yardcontent_to_insert.Information = information;
                yardcontent_to_insert.NoteTime = DateTime.Now;
                chloe_connect.Insert(yardcontent_to_insert);
                MessageBox.Show("录入成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("录入失败！");
                return false;
            }
        }

    //管理员——录入公告栏

        public bool inser_ggcontent(int noteid, String title, String information, DateTime notetime)
        {
            try
            {
                GGContent ggcontent_to_insert = new GGContent();
                ggcontent_to_insert.NoteID = noteid;
                ggcontent_to_insert.Title = title;
                ggcontent_to_insert.Information = information;
                ggcontent_to_insert.NoteTime = DateTime.Now;
                chloe_connect.Insert(ggcontent_to_insert);
                MessageBox.Show("录入成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("录入失败！");
                return false;
            }
        }

    //管理员——录入黑名单

     public bool inser_hmd(String username, String realname)
      {
        try
        {
            HMD hmd_to_insert = new HMD();
            hmd_to_insert.UserName = username;
            hmd_to_insert.RealName = realname;
            chloe_connect.Insert(hmd_to_insert);
            MessageBox.Show("插入成功");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("插入失败");
            return false;
        }
     }

    //管理员——修改用户信息

    public bool XG_YH(String id,int quanxian, int breaktime, String forbid, String award, String breakbj)
    {
        try
        {
            User_BJ YH_xg = new User_BJ();
            YH_xg.UserName = id;
            YH_xg.Permissions = quanxian;
            YH_xg.BreakTime = breaktime;
            YH_xg.Forbid = forbid;
            YH_xg.Award = award;
            YH_xg.BreakBJ = breakbj;
            chloe_connect.Update<User_BJ>(YH_xg);
            MessageBox.Show("修改成功！");
            return true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("修改失败！");
            return false;
        }
    }

    //用户——修改用户个人信息

    public bool xiugai_yh(String password,String realname, String tel)
        {
                Start ab = new Start();
                String cc = Start.CUser;
        try
            {
                Login yh_to_xiugai = new Login();
                yh_to_xiugai.UserName = cc;
                yh_to_xiugai.Password = password;
                yh_to_xiugai.RealName = realname;
                yh_to_xiugai.Tel = tel;
                chloe_connect.Update<Login>(yh_to_xiugai);
                MessageBox.Show("修改成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("修改失败！");
                return false;
            }
        }

    //用户——查看个人信息

    public Login See_myself(String id)
    {
        try
        {
            Login user_info = new Login();
            IQuery<Login> user_info_query = chloe_connect.Query<Login>();
            user_info = user_info_query.Where(a => a.UserName == id).FirstOrDefault();
            return user_info;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return null;
        }
    }


    //管理员——删除用户

    public bool del_YH(String userid)
    {
        try
        {
            Login Del_yh1 = new Login();
            Del_yh1.UserName = userid;
            chloe_connect.Delete(Del_yh1);
            User_BJ Del_yh2 = new User_BJ();
            Del_yh2.UserName = userid;
            chloe_connect.Delete(Del_yh2);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        } 
    }

    //管理员——删除场地信息

    public bool del_Yard(String CDid)
    {
        try
        {
            Yard Del_CD1 = new Yard();
            Del_CD1.YardID = CDid;
            chloe_connect.Delete(Del_CD1);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }

    //管理员——删除黑名单

    public bool del_hmd(String username)
    {
        try
        {
            HMD Del_hmd = new HMD();
            Del_hmd.UserName = username;
            chloe_connect.Delete(Del_hmd);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }

    //管理员——删除所有黑名单

    public bool del_hmd_all()
    {
        try
        {
            HMD Del_hmd_all = new HMD();
            chloe_connect.Delete<HMD>(a=> a.UserName != null);
            MessageBox.Show("删除全部成功！");
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show("删除全部失败！");
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    //管理员——删除所有举报信息

    public bool del_jubao_all()
    {
        try
        {
            YH_JuBao Del_jubao_all = new YH_JuBao();
            chloe_connect.Delete<YH_JuBao>(a => a.UserName != null);
            MessageBox.Show("删除全部成功！");
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show("删除全部失败！");
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    //管理员——删除所有建议信息

    public bool del_suggest_all()
    {
        try
        {
            YH_Suggest Del_suggest_all = new YH_Suggest();
            chloe_connect.Delete<YH_Suggest>(a => a.UserName != null);
            MessageBox.Show("删除全部成功！");
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show("删除全部失败！");
            Console.WriteLine(e.ToString());
            return false;
        }
    }


    //管理员——删除系统通知

    public bool del_xt_note(String noteid1)
    {
        try
        {
            SystemContent Del_xt_note = new SystemContent();
            Del_xt_note.NoteID = int.Parse(noteid1);
            chloe_connect.Delete(Del_xt_note);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }

    //管理员——删除场地通知

    public bool del_cd_note(String noteid2)
    {
        try
        {
            YardContent Del_cd_note = new YardContent();
            Del_cd_note.NoteID = int.Parse(noteid2);
            chloe_connect.Delete(Del_cd_note);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }
    

    //管理员——删除公告栏信息

    public bool del_ggl_note(String noteid3)
    {
        try
        {
            GGContent Del_ggl_note = new GGContent();
            Del_ggl_note.NoteID = int.Parse(noteid3);
            chloe_connect.Delete(Del_ggl_note);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }

    //管理员——删除用户支付信息

    public bool del_pay(String userid)
    {
        try
        {
            PAY Del_pay = new PAY();
            Del_pay.payid = userid;
            chloe_connect.Delete(Del_pay);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }

    //管理员——删除预订信息

    public bool gly_del_booking(String BOOKId)
    {
        try
        {
            Booking del_bookmessage = new Booking();
            del_bookmessage.Book_personid = BOOKId;
            chloe_connect.Delete(del_bookmessage);
            MessageBox.Show("删除成功！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("删除失败！");
            return false;
        }
    }


    //结算完成修改用户标记

    public User_BJ XG_BJ(String id)
    {
        try
        {
            User_BJ bj_xg = new User_BJ();
            IQuery<User_BJ> change_user = chloe_connect.Query<User_BJ>();
            bj_xg=  change_user.Where(a => a.UserName == id).FirstOrDefault();
            bj_xg.Award = "NO";
            bj_xg.BreakBJ = "NO";
            chloe_connect.Update<User_BJ>(bj_xg);
            MessageBox.Show("修改成功！");
            return bj_xg ;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("修改失败！");
            return null;
        }
    }

    //用户——通过场地id查看预订场地信息

    public Booking See_BOOK_CD(String cdid)
    {
        try
        {
            Booking user_info = new Booking();
            IQuery<Booking> user_info_query = chloe_connect.Query<Booking>();
            user_info = user_info_query.Where(a => a.yARDID == cdid).FirstOrDefault();
            return user_info;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return null;
        }
    }

    //用户——通过场地id获取场地价格

    public Yard catchprice(String cdid)
    {
        try
        {
            Yard catch_price = new Yard();
            IQuery<Yard> catch_query = chloe_connect.Query<Yard>();
            catch_price = catch_query.Where(a => a.YardID == cdid).FirstOrDefault();
            return catch_price ;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return null ;
        }
    }


    //用户——预订场地（insert Booking表）
    public bool YH_BOOK_Yard(String yardID,String opentime,String closetime, String bookdate,DateTime realdate,String bookperson,String telphone,String BookBJ)
    {
        Start PP = new Start();
        String pp = Start.CUser;
        try
        {
            Booking yh_book_yard = new Booking();
            yh_book_yard.yARDID= yardID;
            yh_book_yard.OpenTime = opentime;
            yh_book_yard.CloseTime =closetime;
            yh_book_yard.BookDate = bookdate;
            yh_book_yard.REALDate = realdate;
            yh_book_yard.Book_personid = pp;
            yh_book_yard.Book_person = bookperson;
            yh_book_yard.Tel = telphone;
            yh_book_yard.BookCondition = BookBJ;
            chloe_connect.Insert<Booking>(yh_book_yard);
            MessageBox.Show("场地预订成功！请按时到场！如果您临时有事未能到场，请您提前取消预约！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("预订失败！");
            return false;
        }
    }

    //用户——取消预订（new3）
    public bool QUXIAO_YD(String YDCD)
    {
        try
        {

            List<Booking> Del_booknew = new List<Booking>();
            IQuery<Booking> book_query = chloe_connect.Query<Booking>();
            Del_booknew = book_query.Where(a => a.yARDID == YDCD).ToList();
            for (int i = 0; i < Del_booknew.Count(); i++)
            {
                chloe_connect.Delete<Booking>(a=> a.yARDID == YDCD);
                MessageBox.Show(Del_booknew[i].Book_personid  +  Del_booknew[i].yARDID  +  Del_booknew[i].REALDate);
            }
            MessageBox.Show("取消成功!");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("取消失败！");
            return false;
        }
    }
   

    //用于用户执行完支付操作后
    //用户——删除Booking

    public bool shoudaoqian(String ydcd)
    {
        try
        {
            List<Booking> Del_booknew = new List<Booking>();
            IQuery<Booking> book_query = chloe_connect.Query<Booking>();
            Del_booknew = book_query.Where(a => a.yARDID == ydcd).ToList();
            for (int i = 0; i < Del_booknew.Count; i++)
            {
                chloe_connect.Delete<Booking>(a => a.yARDID == ydcd);
            }
            MessageBox.Show("相关数据已经清除!");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            MessageBox.Show("数据清除失败！");
            return false;
        }
    }

    //用户——检查有无预约信息
    //在点击取消预约界面时出发检查

    public int book_find(String bookuser)
    {

        Booking bookfind_result = new Booking();
        IQuery<Booking> find_query = chloe_connect.Query<Booking>();
        bookfind_result = find_query.Where(b => b.Book_personid == bookuser).FirstOrDefault();
        if (bookfind_result == null)
        {
            return 0;
        }
        else 
        {
            return 1;
        }
    }

    //管理员——检查有无预约信息       
    public int gly_book_find()
    {
        Booking gly_find = new Booking();
        IQuery<Booking> book_find = chloe_connect.Query<Booking>();
        gly_find = book_find.FirstOrDefault();
        if (gly_find == null)
        {
            return 0;
        }
        else
        {
            return 1;
        }

    }

    //用户——预订时查重
    public int checkbookmessage(String cdid,String ST,String OT,String day)
    {

        Booking check_result = new Booking();
        IQuery<Booking> check_message_query = chloe_connect.Query<Booking>();
        check_result = check_message_query.Where(a => a.yARDID == cdid).Where(a=> a.OpenTime == ST).Where(a=> a.CloseTime == OT).Where(a=> a.BookDate == day).FirstOrDefault();
        if (check_result == null)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    //支付完成后——1）insert PAY表
    public bool UserPay(String PAYID, String PAYNAME, String YARDid, String BEGINTIME, String OVERTIME, String BOOKTIME, String REALtime,String PAYMONEY, DateTime PAYTIME)
    {
        try
        {
            PAY insert_pay = new PAY();
            insert_pay.payid = PAYID;
            insert_pay.payname = PAYNAME;
            insert_pay.yardid = YARDid;
            insert_pay.begintime = BEGINTIME;
            insert_pay.overtime = OVERTIME;
            insert_pay.booktime = BOOKTIME;
            insert_pay.realTIME = REALtime;
            insert_pay.paymoney = PAYMONEY;
            insert_pay.paytime = DateTime.Now;
            chloe_connect.Insert<PAY>(insert_pay);
            MessageBox.Show("相关信息已登记！");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    //用户——费用结算
    public int USER_CHECK(String personid)
    {
        //检测是否为违约用户
        User_BJ user_CHECK_weiyue = new User_BJ();
        IQuery<User_BJ> user_CHECK_weiyue_query = chloe_connect.Query<User_BJ>();
        user_CHECK_weiyue = user_CHECK_weiyue_query.Where(a => a.UserName == personid).FirstOrDefault();
        if (user_CHECK_weiyue.BreakBJ.ToString() == "YES")
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public int User_checkkkkk(String personid)
    {
        //检测是否为奖励用户
        User_BJ user_CHECK_jiangli = new User_BJ();
        IQuery<User_BJ> user_CHECK_jiangli_query = chloe_connect.Query<User_BJ>();
        user_CHECK_jiangli = user_CHECK_jiangli_query.Where(b => b.UserName == personid).FirstOrDefault();       
        if (user_CHECK_jiangli.Award.ToString() == "YES")
            {
                  return 3;
            }
        else
           {
                 return 4;
           }
    }
        
}




