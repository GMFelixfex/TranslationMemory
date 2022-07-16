namespace TranslationMemoryUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEmail()
        {
            bool result = true;
            for (int i = 0; i < emailList.Length; i++)
            {
                if (!TranslationMemoryForm.Code.DataHandling.DataChecker.CheckEmail(emailList[i]))
                {
                    result = false;
                }
            }    
                
            Assert.True(result);
        }

        [Test]
        public void TestUserNameMulti()
        {
            bool result = true;
            for (int i = 0; i < namesList.Length; i++)
            {
                if (!TranslationMemoryForm.Code.DataHandling.DataChecker.CheckName(namesList[i]))
                {
                    result = false;
                }
            }
            Assert.True(result);
        }

        [Test]
        public void TestPassword()
        {
            bool result = TranslationMemoryForm.Code.DataHandling.DataChecker.CheckPassword("!%%§TestPW1234");
            Assert.True(result);
        }
        [Test]
        public void TestUserNameSingle()
        {
            bool result = true;

            result = TranslationMemoryForm.Code.DataHandling.DataChecker.CheckName("StrangerThingsFan1234");

            Assert.True(result);
        }



        string[] namesList = new string[] { "Emily Dixon", "Robert Vega", "Michael Peterson", "Kimberly Watts", "Tyler Ballard", "Laura Gonzales", "Alexander Sampson", "Alyssa Lewis", "Tiffany Lee", "Daniel Rodriguez", "Jaime Ramos", "Beth Cruz", "Eric Smith", "Elizabeth Cooper", "Gregory Mullins", "Desiree Holloway", "Natasha Bartlett", "Kiara Morales", "Judy Escobar", "Michelle Hernandez", "Mary Valentine", "Brandi Sanchez", "Stephanie Walker", "Joshua Nelson", "Alicia Smith", "Anita Conner", "Crystal Ryan", "Christopher Contreras", "Jeffery Rodriguez", "Rebecca Peterson", "Valerie Lynn", "Henry Blackwell", "George Nelson", "Jeremy Hudson", "Richard Banks", "Abigail Adams", "Cynthia Reese", "Scott Werner", "Alicia Lewis", "Mary Reed DVM", "Gary Dean", "Ashley Ward", "Robert King", "Alejandra Gaines", "Jessica Stafford", "Anthony Lopez", "Dale Baker", "Troy Nunez", "Michael Gordon DVM", "Rachel Howard", "John Floyd", "Patricia Reeves", "Ashley Avila", "Kayla Graves", "Shelia Castaneda", "Christopher Stephens", "Alyssa Greene", "Nancy Madden", "Alan Martinez", "Samantha Rangel", "Cody Steele", "Christopher Brown", "Christopher Greer", "Michelle Clark", "Brandon Myers", "James Hayes", "Louis Wise", "Ian Hernandez", "Lisa Anderson", "Raymond Mitchell", "Steve Acosta", "Carmen Bowman", "Michael Mora", "Emily Graves", "Jessica Church", "Jennifer Griffin", "Eric Haynes", "Logan Rogers", "Rhonda Scott", "Ricky Durham", "John Thompson", "John Lewis", "Taylor Burns", "Rebecca Smith", "Cindy Solomon", "Rebecca Ward PhD", "Brian Harding", "Nancy Porter", "Samuel Jackson", "Eric Walker", "Tommy Brooks", "Shirley Medina", "William Gomez", "Michelle Yu", "Corey Copeland", "Harry Lamb", "George Bright", "Sergio Jordan" };
        string[] emailList = new string[] { "mina42@donnelly.com", "augusta62@gmail.com", "ohara.jake@quitzon.org", "leda.bogisich@kuhn.com", "lorenzo50@hotmail.com", "hcassin@murphy.com", "wolff.scot@hotmail.com", "kbeier@walker.com", "paucek.ocie@hotmail.com", "lubowitz.mateo@ryan.biz", "wisozk.maximo@cummings.com", "hermiston.reina@lubowitz.info", "lula31@kihn.com", "amurphy@hotmail.com", "zieme.ansley@hotmail.com", "garett.harris@yahoo.com", "dedric84@hotmail.com", "malvina.klein@yahoo.com", "bosco.wendell@yahoo.com", "ignatius60@hotmail.com", "delaney09@hotmail.com", "marlin78@bashirian.biz", "hills.payton@stokes.info", "clegros@bahringer.net", "rstroman@kreiger.com", "qthiel@kiehn.org", "korey14@hotmail.com", "tschneider@purdy.com", "macy.hermann@yahoo.com", "thomas33@hotmail.com", "kutch.destany@wisoky.com", "retha59@hotmail.com", "freddy.zieme@sipes.com", "fwalker@kiehn.com", "fcrist@gmail.com", "saul.konopelski@hotmail.com", "sgreen@hintz.com", "lokuneva@walter.com", "dominic.dickinson@herzog.net", "hugh.hamill@douglas.info", "mohr.eden@yahoo.com", "joaquin.ziemann@yahoo.com", "boconner@ernser.info", "woreilly@gmail.com", "bmertz@hills.com", "krajcik.lambert@gmail.com", "huel.isidro@harber.com", "ortiz.makayla@lang.com", "wfahey@gmail.com", "kip96@gmail.com", "baylee58@stamm.com", "emil86@keebler.com", "ward.walsh@gmail.com", "frederik22@ondricka.com", "grimes.orland@ortiz.net", "marvin.harvey@huels.com", "damian.armstrong@gmail.com", "vhyatt@feest.biz", "ofeeney@lockman.info", "corene.kemmer@mohr.org", "clemmie26@hotmail.com", "ziemann.georgiana@okon.biz", "qreinger@pfeffer.com", "vinnie81@strosin.com", "olubowitz@maggio.biz", "adrain92@yahoo.com", "lukas.lowe@robel.com", "ncremin@connelly.com", "aniya70@parisian.biz", "ryley.king@gmail.com", "uernser@gmail.com", "pmills@gmail.com", "bpurdy@yahoo.com", "abbigail.legros@hoeger.com", "wilderman.lori@satterfield.biz", "marco.mayert@gmail.com", "sandrine47@smitham.com", "jgerlach@yahoo.com", "kessler.ayden@gmail.com", "maverick76@smith.com", "mina60@koepp.com", "qeichmann@hermiston.com", "plittel@gmail.com", "bechtelar.lisa@hessel.com", "hand.emery@sporer.biz", "nolan.neal@keeling.net", "electa.barrows@stehr.com", "flatley.tamia@batz.com", "stoltenberg.dante@runte.org", "sdamore@gmail.com", "kiarra85@yahoo.com", "tillman.marian@yahoo.com", "leopoldo.volkman@kovacek.biz", "tamia16@yahoo.com", "qosinski@vonrueden.org", "xmoen@runolfsdottir.com", "kellen71@stracke.com", "crist.clair@harvey.org", "samson63@bruen.net", "jerald.homenick@yahoo.com", "antonina89@hotmail.com", "donnell00@fadel.biz", "oheller@schmitt.com", "bethany.trantow@schultz.net", "sammie75@labadie.org", "roma.howe@gmail.com", "balistreri.irma@raynor.org", "flind@gmail.com", "braeden92@hotmail.com", "uconroy@zemlak.info", "carolyn.haley@mohr.com", "snader@konopelski.com", "klein.freddie@gerhold.com", "treutel.pearline@koss.com", "marcia.hills@little.com", "juliet.ziemann@nienow.biz", "ledner.selmer@gmail.com", "ambrose.kirlin@yahoo.com", "paucek.michale@yahoo.com", "hlegros@kassulke.com", "forest.hodkiewicz@yahoo.com", "leannon.shayne@marvin.net", "reva35@kozey.net", "sandy.balistreri@hotmail.com", "morris06@yahoo.com", "streich.ava@mckenzie.com", "schoen.mariana@lowe.com", "braxton92@monahan.com", "dion.pagac@romaguera.com", "deckow.americo@yahoo.com", "bettie08@yahoo.com", "karley68@hotmail.com", "xanderson@cormier.com", "frank.johnson@fisher.org", "michael.west@lesch.com", "norbert45@hotmail.com", "troy60@hessel.org", "melany.mraz@kassulke.com", "lila.wilkinson@olson.com", "nhermiston@gmail.com", "jarvis72@wilderman.com", "mayert.randall@schmitt.com", "koepp.emmy@mclaughlin.info", "brekke.norma@yahoo.com", "vspencer@jaskolski.com", "kuvalis.myron@schroeder.net", "qharber@lueilwitz.info", "freddie16@reichert.com", "bwillms@yahoo.com", "celia11@pagac.net", "lleffler@feeney.biz", "miles74@gmail.com", "elroy63@dietrich.com", "general69@hotmail.com", "kovacek.billie@yahoo.com", "durgan.diana@gmail.com", "padberg.noemie@reynolds.com", "rbergnaum@orn.biz", "kiley.metz@treutel.com", "ara.johnston@koelpin.net", "gkautzer@gmail.com", "ismael59@kuhlman.com", "ora22@gmail.com", "christiana73@mitchell.info", "kassulke.jettie@bernhard.com", "gbrakus@fahey.biz", "hahn.sarai@mayer.net", "sherwood00@funk.com", "lueilwitz.stuart@rohan.biz", "blanda.allison@hotmail.com", "fmohr@kerluke.com", "prohaska.durward@gmail.com", "tamara.goldner@yahoo.com", "marcel.feeney@wilderman.com", "pacocha.phyllis@marquardt.net", "ubins@boehm.biz", "borer.leo@gmail.com", "stanton.chet@tromp.com", "adella.pouros@boyle.net", "guy21@yahoo.com", "smarquardt@okeefe.com", "manuela.mayert@hotmail.com", "herzog.shane@hayes.com", "reilly.adriel@gmail.com", "lucie.russel@gmail.com", "rosendo85@lindgren.info", "rheathcote@yahoo.com", "cody55@yahoo.com", "aniya34@bosco.com", "xmueller@yahoo.com", "egrady@yahoo.com", "tnienow@yahoo.com", "mertz.vivienne@shanahan.com", "glover.crystal@muller.info", "kertzmann.bette@yahoo.com", "denesik.daren@daugherty.com", "ziemann.jake@gmail.com", "verlie14@hotmail.com", "moshe.jacobson@gmail.com", "mertz.junius@hotmail.com" };
    }
}