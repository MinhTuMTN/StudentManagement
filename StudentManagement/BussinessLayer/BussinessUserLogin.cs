using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.DataAccessLayer;
using StudentManagement.DataAccessLayer.Models;

namespace StudentManagement.BussinessLayer
{
    public class BussinessUserLogin
    {
        /// <summary>
        /// Tạo người dùng mới
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <param name="error"></param>
        /// <param name="isActived"></param>
        /// <returns></returns>
        public int CreateUser(string userName, string password, int role, ref string error, bool isActived = true)
        {
            try
            {
                using (var context = new Context())
                {
                    var newUser = new UserLogin()
                    {
                        UserName = userName.Trim(),
                        Password = password.Trim(),
                        Role = role,
                        IsActived = isActived
                    };

                    context.UserLogins.Add(newUser);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        /// <summary>
        /// Cập nhật thông tin người dùng
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public int UpdateUser(string userName, string password, int role, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var userSearch = context.UserLogins.Find(userName);

                    if (userSearch != null)
                    {
                        userSearch.Password = password.Trim();
                        userSearch.Role = role;
                    }
                    else
                    {
                        error = "Không tìm thấy tài khoản này";
                        return -1;
                    }

                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        /// <summary>
        /// Xóa người dùng
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public int DeleteUser(string userName, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var userDelete = context.UserLogins.Find(userName);

                    if (userDelete != null)
                    {
                        userDelete.IsActived = false;
                        return context.SaveChanges();
                    }
                    else
                    {
                        error = "Không tìm thấy tài khoản này";
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -1;
        }
        /// <summary>
        /// Kiểm tra password có đúng hay không
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool CheckPassword(string userName, string password, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var userSearch = context.UserLogins.Find(userName);

                    if(userName == null || userSearch.IsActived == false)
                    {
                        error = "Không tìm thấy người dùng";
                        return false;
                    }
                    else
                    {
                        if (userSearch.Password.Equals(password.Trim()))
                            return true;
                        else
                        {
                            error = "Mật khẩu không đúng";
                            return false;
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return false;
        }
    } 
}
