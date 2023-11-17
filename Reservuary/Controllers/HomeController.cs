using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity;
using Reservuary.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;

namespace Reservuary.Controllers
{
    public class HomeController : Controller
    {
        public inventorEntities db = new inventorEntities();
        public KepDataLoggerEntities db2 = new KepDataLoggerEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult podpisanty()
        {
            List<Podpisanty> podpisanty = new List<Podpisanty>();
            podpisanty = db.Podpisanty.OrderBy(h=>h.IDFilial).ToList();

            SelectList komis = new SelectList(db.location, "id", "name");
            ViewBag.komis = komis;

            return View(podpisanty);
        }
        public ActionResult Gomel()
        {
            List<tanks> gomel = new List<tanks>();
            gomel = db.tanks.Where(j => j.location_ID == 1).ToList();
            ViewBag.gomel =gomel;

            GomelNS1_Level_Tank400_1 GomelUr1 = new GomelNS1_Level_Tank400_1();
            GomelUr1 = db2.GomelNS1_Level_Tank400_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr1 = GomelUr1.value;
            
            GomelNS1_Level_Tank100_1 GomelUr3 = new GomelNS1_Level_Tank100_1();
            GomelUr3 = db2.GomelNS1_Level_Tank100_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr3 = GomelUr3.value;
           
            GomelNS1_Level_Tank100_2 GomelUr4 = new GomelNS1_Level_Tank100_2();
            GomelUr4 = db2.GomelNS1_Level_Tank100_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr4 = GomelUr4.value;

            GomelNS1_Level_TankLeak20 GomelUr5 = new GomelNS1_Level_TankLeak20();
            GomelUr5 = db2.GomelNS1_Level_TankLeak20.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr5 = GomelUr5.value;

            GomelScr_Level_TankLeak30 GomelUr6 = new GomelScr_Level_TankLeak30();
            GomelUr6 = db2.GomelScr_Level_TankLeak30.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr6 = GomelUr6.value;
                        
            GomelNS1_Level_Tank400_1 GomelUr8 = new GomelNS1_Level_Tank400_1();
            GomelUr8 = db2.GomelNS1_Level_Tank400_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr8 = GomelUr8.value;

            GomelNS1_Level_TankLeak12 GomelUr7 = new GomelNS1_Level_TankLeak12();
            GomelUr7 = db2.GomelNS1_Level_TankLeak12.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GomelUr7 = GomelUr7.value;
                             
            return View(gomel);
        }
        public ActionResult Zaschebe()
        {
            List<tanks> zaschebe = new List<tanks>();
            zaschebe = db.tanks.Where(j => j.location_ID == 2).ToList();
            ViewBag.zaschebe = zaschebe;

            ZaschNS1_Level_TankLeak25 ZaschUr1 = new ZaschNS1_Level_TankLeak25();
            ZaschUr1 = db2.ZaschNS1_Level_TankLeak25.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.ZaschUr1 = ZaschUr1.value;

            ZaschNS2_Level_TankLeak200_1 ZaschUr2 = new ZaschNS2_Level_TankLeak200_1();
            ZaschUr2 = db2.ZaschNS2_Level_TankLeak200_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.ZaschUr2 = ZaschUr2.value;

            ZaschNS2_Level_TankLeak200_2 ZaschUr3 = new ZaschNS2_Level_TankLeak200_2();
            ZaschUr3 = db2.ZaschNS2_Level_TankLeak200_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.ZaschUr3 = ZaschUr3.value;

            ZaschNS2_Level_TankLeak100_1 ZaschUr4 = new ZaschNS2_Level_TankLeak100_1();
            ZaschUr4 = db2.ZaschNS2_Level_TankLeak100_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.ZaschUr4 = ZaschUr4.value;

            ZaschNS2_Level_TankLeak100_2 ZaschUr5 = new ZaschNS2_Level_TankLeak100_2();
            ZaschUr5 = db2.ZaschNS2_Level_TankLeak100_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.ZaschUr5 = ZaschUr5.value;

            ZaschNS2_Level_TankLeak100_3 ZaschUr6 = new ZaschNS2_Level_TankLeak100_3();
            ZaschUr6 = db2.ZaschNS2_Level_TankLeak100_3.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.ZaschUr6 = ZaschUr6.value;

            return View(zaschebe);
        }
        public ActionResult Mozyr()
        {
            List<tanks> mozyr = new List<tanks>();
            mozyr = db.tanks.Where(j => j.location_ID == 4).ToList();
            ViewBag.mozyr = mozyr;

            SIKN461_Level_TankLeak MozUr1 = new SIKN461_Level_TankLeak();
            MozUr1 = db2.SIKN461_Level_TankLeak.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.MozUr1 = MozUr1.value;

            MozyrBK1_Level_TankLeak25_Scr4 MozUr2 = new MozyrBK1_Level_TankLeak25_Scr4();
            MozUr2 = db2.MozyrBK1_Level_TankLeak25_Scr4.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.MozUr2 = MozUr2.value;

            MozyrNS41_Level_TankLeak25 MozUr3 = new MozyrNS41_Level_TankLeak25();
            MozUr3 = db2.MozyrNS41_Level_TankLeak25.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.MozUr3 = MozUr3.value;

            MozyrNS2_Level_TanlLeak1_2 MozUr4 = new MozyrNS2_Level_TanlLeak1_2();
            MozUr4 = db2.MozyrNS2_Level_TanlLeak1_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.MozUr4 = MozUr4.value;

            MozyrNS2_Level_TanlLeak25 MozUr5 = new MozyrNS2_Level_TanlLeak25();
            MozUr5 = db2.MozyrNS2_Level_TanlLeak25.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.MozUr5 = MozUr5.value;

            MozyrNS3_Level_TankLeak47 MozUr6 = new MozyrNS3_Level_TankLeak47();
            MozUr6 = db2.MozyrNS3_Level_TankLeak47.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.MozUr6 = MozUr6.value;

            return View(mozyr);
        }
        public ActionResult Turov()
        {
            List<tanks> turov = new List<tanks>();
            turov = db.tanks.Where(j => j.location_ID == 7).ToList();
            ViewBag.turov = turov;

            TurovNS2_Level_TankLeak200_1 TurUr1 = new TurovNS2_Level_TankLeak200_1();
            TurUr1 = db2.TurovNS2_Level_TankLeak200_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.TurUr1 = TurUr1.value;

            TurovNS2_Level_TankLeak200_2 TurUr2 = new TurovNS2_Level_TankLeak200_2();
            TurUr2 = db2.TurovNS2_Level_TankLeak200_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.TurUr2 = TurUr2.value;

            TurovNS2_Level_TankLeak100_1 TurUr3 = new TurovNS2_Level_TankLeak100_1();
            TurUr3 = db2.TurovNS2_Level_TankLeak100_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.TurUr3 = TurUr3.value;

            TurovNS2_Level_TankLeak100_2 TurUr4 = new TurovNS2_Level_TankLeak100_2();
            TurUr4 = db2.TurovNS2_Level_TankLeak100_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.TurUr4 = TurUr4.value;

            TurovNS1_Level_TankLeak12 TurUr5 = new TurovNS1_Level_TankLeak12();
            TurUr5 = db2.TurovNS1_Level_TankLeak12.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.TurUr5 = TurUr5.value;

            return View(turov);
        }
        public ActionResult Pinsk()
        {
            List<tanks> pinsk = new List<tanks>();
            pinsk = db.tanks.Where(j => j.location_ID == 6).ToList();
            ViewBag.pinsk = pinsk;

            PinskNS2_Level_TankLeak200_1 PinUr1 = new PinskNS2_Level_TankLeak200_1();
            PinUr1 = db2.PinskNS2_Level_TankLeak200_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.PinUr1 = PinUr1.value;

            PinskNS2_Level_TankLeak200_2 PinUr2 = new PinskNS2_Level_TankLeak200_2();
            PinUr2 = db2.PinskNS2_Level_TankLeak200_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.PinUr2 = PinUr2.value;

            PinskNS2_Level_TankLeak25 PinUr3 = new PinskNS2_Level_TankLeak25();
            PinUr3 = db2.PinskNS2_Level_TankLeak25.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.PinUr3 = PinUr3.value;

            PinskScr_Level_TankLeak25 PinUr4 = new PinskScr_Level_TankLeak25();
            PinUr4 = db2.PinskScr_Level_TankLeak25.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.PinUr4 = PinUr4.value;

            PinskNS1_Level_TankLeak40 PinUr5 = new PinskNS1_Level_TankLeak40();
            PinUr5 = db2.PinskNS1_Level_TankLeak40.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.PinUr5 = PinUr5.value;

            return View(pinsk);
        }
        public ActionResult Kobrin()
        {
            List<tanks> kobrin = new List<tanks>();
            kobrin = db.tanks.Where(j => j.location_ID == 3).ToList();
            ViewBag.kobrin = kobrin;

            KobrinNS2_Level_TankLeak200_1 KobUr1 = new KobrinNS2_Level_TankLeak200_1();
            KobUr1 = db2.KobrinNS2_Level_TankLeak200_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.KobUr1 = KobUr1.value;

            KobrinNS2_Level_TankLeak200_2 KobUr2 = new KobrinNS2_Level_TankLeak200_2();
            KobUr2 = db2.KobrinNS2_Level_TankLeak200_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.KobUr2 = KobUr2.value;

            KobrinNS2_Level_TankLeak100_1 KobUr3 = new KobrinNS2_Level_TankLeak100_1();
            KobUr3 = db2.KobrinNS2_Level_TankLeak100_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.KobUr3 = KobUr3.value;

            KobrinNS2_Level_TankLeak100_2 KobUr4 = new KobrinNS2_Level_TankLeak100_2();
            KobUr4 = db2.KobrinNS2_Level_TankLeak100_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.KobUr4 = KobUr4.value;

            KobrinNS1_Level_TankLeak12 KobUr5 = new KobrinNS1_Level_TankLeak12();
            KobUr5 = db2.KobrinNS1_Level_TankLeak12.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.KobUr5 = KobUr5.value;

            return View(kobrin);
        }
        public ActionResult Novopolock()
        {
            List<tanks> novopolock = new List<tanks>();
            novopolock = db.tanks.Where(j => j.location_ID == 5).ToList();
            ViewBag.novopolock = novopolock;

            return View(novopolock);
        }
        public ActionResult Gorki()
        {
            List<tanks> gorki = new List<tanks>();
            gorki = db.tanks.Where(j => j.location_ID == 9).ToList();
            ViewBag.gorki = gorki;

            GorkiNS2_Level_TankLeak25_1 GorkiUr1 = new GorkiNS2_Level_TankLeak25_1();
            GorkiUr1 = db2.GorkiNS2_Level_TankLeak25_1.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GorkiUr1 = GorkiUr1.value;

            GorkiNS2_Level_TankLeak25_2 GorkiUr2 = new GorkiNS2_Level_TankLeak25_2();
            GorkiUr2 = db2.GorkiNS2_Level_TankLeak25_2.FirstOrDefault(a => a.dt <= DateTime.Now);
            ViewBag.GorkiUr2 = GorkiUr2.value;

            return View(gorki);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpPost]
        public ActionResult WriteDB(string LocID, string IDRez, string Uroven, string V20, string Temperat, string V, string Plotnost, string massa, string UrovH2O, string VH2O)
        {
            try
            {                
                InventoryM inventM = new InventoryM();
                inventM.LocID = Convert.ToInt32(LocID);
                inventM.IDRez = Convert.ToInt32(IDRez);
                inventM.Date = DateTime.Now;
                inventM.Uroven = Convert.ToDecimal(Uroven);
                inventM.V20 = Convert.ToDecimal(V20);
                inventM.Temper = Convert.ToDecimal(Temperat);
                inventM.Vol = Convert.ToDecimal(V);
                inventM.Plotnost = Convert.ToDecimal(Plotnost);
                inventM.Massa = Convert.ToDecimal(massa);
                inventM.UrovH2O = Convert.ToDecimal(UrovH2O);
                inventM.VH2O = Convert.ToDecimal(VH2O);
                inventM.UserDC = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                db.InventoryM.Add(inventM);

                db.SaveChanges();

                ViewBag.Message = "Запись добавлена";
            }
            catch(Exception ex)
            {                
                ViewBag.Message = ex.ToString();
            }
            return PartialView();
        }
        [HttpPost]
        public ActionResult ModalDB()
        {
            
            return View();
        }

        //-----------------------------//

        // Редактирование члена комиссии//

        public ActionResult KomissiyaEdit(int ID)
        {
            Podpisanty pod = new Podpisanty();
            pod = db.Podpisanty.FirstOrDefault(a => a.ID == ID);
            return PartialView(pod);
        }
        //-------------------------------//

        //Сохранение редактирования члена комиссии------------//
        [HttpPost]
        public ActionResult KomissiyaEditSave(int ID, string Nazn, string Doljnost, string FIO)
        {
            try
            {
                Podpisanty pod = new Podpisanty();
                pod = db.Podpisanty.FirstOrDefault(s => s.ID == ID);

                pod.Nazn = Nazn.Trim();
                pod.Doljnost = Doljnost.Trim();
                pod.FIO = FIO.Trim();
                db.SaveChanges();

                ViewBag.Message = "Подписант успешно изменен";

            }
            catch (Exception e)
            {
                ViewBag.Message = "Ошибка. Текст ошибки: " + e.ToString();
            }

            return PartialView();
        }
        //-----------------------------//
        //----------Добавление члена комиссии-----------------------//

        public ActionResult AddKomissiya()
        {
            SelectList komis = new SelectList(db.location, "id", "name");
            ViewBag.komis = komis;
            return PartialView();
        }
        //--------------------------//
        //-----Сохранение добавления члена комиссии-----------//
        [HttpPost]
        public ActionResult KomissiyaSave(string location, string Nazn, string Doljnost, string FIO)
        {
            try
            {
                Podpisanty kom = new Podpisanty();
                kom.IDFilial = Convert.ToInt32(location);
                kom.Nazn = Nazn.Trim();
                kom.Doljnost = Doljnost.Trim();
                kom.FIO = FIO.Trim();
                db.Podpisanty.Add(kom);

                db.SaveChanges();

                ViewBag.Message = "Член комиссии успешно добавлендобавлен!";
            }
            catch (Exception ex)
            {


                ViewBag.Message = ex.ToString();
            }

            return PartialView();
        }
        //----------------------------------//
        // удаление подписанта//

        public ActionResult DeletePodpis(int ID)
        {
            Podpisanty podp = new Podpisanty();
            podp = db.Podpisanty.FirstOrDefault(a => a.ID == ID);
            return PartialView(podp);
        }
        //-----------------------------//

        // Подтверждение удаления подписанта//
        public ActionResult DeletePodpisOK(int ID)
        {
            try
            {

                Podpisanty podpis = new Podpisanty();
                podpis = db.Podpisanty.FirstOrDefault(a => a.ID == ID);
                db.Podpisanty.Remove(podpis);
                db.SaveChanges();

                ViewBag.Message = "Подписант успешно удален!";
            }
            catch
            {
                ViewBag.Message = "Ошибка удаления";
            }

            return PartialView();
        }
        //----------------Формирование отчета PDF---------------//
        public ActionResult Report(string dat)
        {

            MemoryStream workStream = new MemoryStream();

            // Имя создаваемого файла. 
            string strPDFFileName = string.Format("Report.pdf");
            Document doc = new Document();
            doc.SetPageSize(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, workStream).CloseStream = false;
                                   
            // Подключение русскоязычного шрифта.
            string font = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            BaseFont baseFont = BaseFont.CreateFont(font, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font f12 = new Font(baseFont, 12);
            Font f14 = new Font(baseFont, 14);
            Font f16 = new Font(baseFont, 16);
            Font f12Bold = new Font(baseFont, 12, Font.BOLD);
            Font f18Bold = new Font(baseFont, 18, Font.BOLD);
            Font f20Bold = new Font(baseFont, 20, Font.BOLD);

            // Открытие документа.
            doc.Open();

            // Создание элементов.
            Paragraph par1 = new Paragraph("WWWWW", f12Bold);
            Paragraph par2 = new Paragraph("УТВЕРЖДАЮ", f20Bold);
            Paragraph par3 = new Paragraph("Штат в количестве  человек", f12Bold);
            Paragraph par4 = new Paragraph("С месячным фондом  рублей", f12Bold);
            Paragraph par5 = new Paragraph("Генеральный директор ___________ Борисенко О.Л.", f12Bold);
            Paragraph par6 = new Paragraph("Приказ №_____ от _____", f12Bold);
            par1.Alignment = Element.ALIGN_RIGHT;
            par2.Alignment = Element.ALIGN_RIGHT;
            par3.Alignment = Element.ALIGN_RIGHT;
            par4.Alignment = Element.ALIGN_RIGHT;
            par5.Alignment = Element.ALIGN_RIGHT;
            par6.Alignment = Element.ALIGN_RIGHT;
                     
                      
            // Добавление элементов в документ.
            doc.Add(par1);
            doc.Add(par2);
            doc.Add(par3);
            doc.Add(par4);
            doc.Add(par5);
            doc.Add(par6);
            doc.Add(new Paragraph(" ", f16));
            
            // Закрытие документа.  
            doc.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;


            return File(workStream, "application/pdf", strPDFFileName);
        }

    }
}