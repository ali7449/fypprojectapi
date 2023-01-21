using fypprojectapi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace fypprojectapi.Controllers
{
    public class UserdDataController : ApiController
    {
        RENT_A_DRESSEntities db = new RENT_A_DRESSEntities();
        [HttpGet]
        public HttpResponseMessage showUsers()
        {
            try
            {
                var data = db.USERINFOes.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        public HttpResponseMessage saveuser(USERINFO u)
        {
            try
            {
                db.USERINFOes.Add(u);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "user with id : " + u.id + "saved");

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /* [HttpPost]
         public HttpResponseMessage UploadFile()
         {
             // Check if the request contains multipart/form-data.
             if (!Request.Content.IsMimeMultipartContent())
             {
                 throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
             }

             var root = HttpContext.Current.Server.MapPath("~/App_Data");
             var provider = new MultipartFormDataStreamProvider(root);

             try
             {
                 // Read the form data and get file names
                 Request.Content.ReadAsMultipart(provider);

                 // This illustrates how to get the file names.
                 foreach (MultipartFileData file in provider.FileData)
                 {
                     Trace.WriteLine(file.Headers.ContentDisposition.FileName);
                     Trace.WriteLine("Server file path: " + file.LocalFileName);
                 }
                 return Request.CreateResponse(HttpStatusCode.OK);
             }
             catch (System.Exception e)
             {
                 return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
             }
         }
 */
        
        [HttpPost]
        public IHttpActionResult uploadImage([FromBody] DRESSIMAGE ii)
        {
            var form = HttpContext.Current.Request.Form;
          //  string DeptName = form["name"];

            var files = HttpContext.Current.Request.Files;
            //string dateTimeStamp = DateTime.Now.ToString();
            string path = HttpContext.Current.Server.MapPath("~/Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        //    int rowEffectd = 0;
            string fileData = null;
            for (int i = 0; i < files.Count; i++)
            {
                fileData = /*dateTimeStamp +*/ files[i].FileName;
                files[i].SaveAs(path + "/" + fileData);
               // rowEffectd = new Department().insert(new Department { name = DeptName, imageData = fileData });
            }
            ii.dressimage1 = fileData;
            db.DRESSIMAGEs.Add(ii);
            db.SaveChanges();
            
            return Ok("Image uploaded" + " Name:");
        }

        [HttpPost]
        public HttpResponseMessage savedress()
        {
            /*try
            {
                db.DRESSIMAGEs.Add(u);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "user with id : " + u.dressid + "saved");

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }*/

            try
            {
                var form = HttpContext.Current.Request.Files[0];
/*
                string flowerName = form["name"];
                string color = form["color"];
                string season = form["season"];
                var files = HttpContext.Current.Request.Files;
                DateTime dt = DateTime.Now;
                string path = HttpContext.Current.Server.MapPath("~/Images");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string fileData = null;
                for (int i = 0; i < files.Count; i++)
                {
                    fileData = $"{dt.Year}_{dt.Month}_{dt.Day}_{dt.Hour}_{dt.Minute}_{dt.Second}_{dt.Millisecond}_{files[i].FileName}";
                    files[i].SaveAs(path + "/" + fileData);
                 //   FlowerTask f = new FlowerTask() { name = flowerName, image = fileData, color = color, season = season };
               //     db.FlowerTasks.Add(f);
                 //   db.SaveChanges();*/
             //
                return Request.CreateResponse(HttpStatusCode.OK, $"Image uploaded");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }



    }
}