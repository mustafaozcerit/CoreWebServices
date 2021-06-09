using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Controllers;
using WindowsServiceHosting.Models.DateUpdate;

namespace WindowsServiceHosting
{
    public class DateUpdateContoller
    {
        DateUpdateContext dateDB = new DateUpdateContext();

        WriteToFiles writeToFiles = new WriteToFiles();

        DateTime dateTime;

        public void Update()
        {
            List<Models.DateUpdate.Date> dateList = dateDB.Date.ToList();

            if (dateList.Count == 0)
            {
                try
                {
                    dateTime = DateTime.Now;

                    dateDB.Date.Add(new Date
                    {
                        UpdateDatetimeServices = dateTime
                    });
                    dateDB.SaveChanges();
                }
                catch (Exception e)
                {
                    writeToFiles.WriteToFile("Tarih Güncellmesinde beklenmeyen bir hata oluştu: " + e.Message.ToString());
                    string message = "Tarih Güncellmesinde beklenmeyen bir hata oluştu";
                    writeToFiles.Error(message);
                }
            }
            else
            {
                dateTime = (DateTime)dateList.FirstOrDefault().UpdateDatetimeServices;
                writeToFiles.WriteToFile("Son Güncellenme Tarihi:  " + dateTime);
            }

            WebGuncelle webGuncelle = new WebGuncelle();
            webGuncelle.Guncelle(dateTime);
        }
        public void UpdateSuccess()
        {
            dateTime = DateTime.Now;
            Models.DateUpdate.Date date = dateDB.Date.FirstOrDefault();
            date.UpdateDatetimeServices = dateTime;
            dateDB.Date.Update(date);
            dateDB.SaveChanges();
            writeToFiles.WriteToFile("Güncelleme Tarihi: " + dateTime + "  Olarak Değiştirilmiştir.");
            writeToFiles.Success();
        }
    }
}
