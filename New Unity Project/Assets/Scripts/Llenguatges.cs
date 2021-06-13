using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llenguatges : MonoBehaviour
{
    // Start is called before the first frame update
    public static Dictionary<string, string> llenguatges = new Dictionary<string, string>();
    public static string languge = "ENG";
    public void setlangugeVAL(){
        languge = "VAL";
    }
    public void setlangugeESP(){
        languge = "ESP";
    }
    public void setlangugeENG(){
        languge = "ENG";
    }
    public void setlangugeROM(){
        languge = "ROM";
    }
    public void setlangugeUKR(){
        languge = "UKR";
    }
    public void setlangugeRUS(){
        languge = "RUS";
    }
    void Start(){
        llenguatges.Add("VAL-Malalt","Malalt");
        llenguatges.Add("ESP-Malalt","Enfermo");
        llenguatges.Add("ENG-Malalt","Sick");
        llenguatges.Add("ROM-Malalt","Bolnav");
        llenguatges.Add("UKR-Malalt","Хворий");
        llenguatges.Add("RUS-Malalt","Больной");

        llenguatges.Add("VAL-Saludable","Saludable");
        llenguatges.Add("ESP-Saludable","Saludable");
        llenguatges.Add("ENG-Saludable","Healthy");
        llenguatges.Add("ROM-Saludable","Sănătos");
        llenguatges.Add("UKR-Saludable","Здоровий");
        llenguatges.Add("RUS-Saludable","Здоров");

        llenguatges.Add("VAL-Start","Començar");
        llenguatges.Add("ESP-Start","Empezar");
        llenguatges.Add("ENG-Start","Start");
        llenguatges.Add("ROM-Start","Start");
        llenguatges.Add("UKR-Start","Почати гру");
        llenguatges.Add("RUS-Start","Начать игру");

        llenguatges.Add("VAL-Idioma","Idiomes");
        llenguatges.Add("ESP-Idioma","Idiomas");
        llenguatges.Add("ENG-Idioma","Languages");
        llenguatges.Add("ROM-Idioma","Limbi");
        llenguatges.Add("UKR-Idioma","Вибір мови");
        llenguatges.Add("RUS-Idioma","Выбор языка");

        llenguatges.Add("VAL-Back","Enrere");
        llenguatges.Add("ESP-Back","Atrás");
        llenguatges.Add("ENG-Back","Back");
        llenguatges.Add("ROM-Back","Înapoi");
        llenguatges.Add("UKR-Back","Назад");
        llenguatges.Add("RUS-Back","Назад");

        llenguatges.Add("VAL-OK","Entesos");
        llenguatges.Add("ESP-OK","Entendido");
        llenguatges.Add("ENG-OK","OK");
        llenguatges.Add("ROM-OK","OK");
        llenguatges.Add("UKR-OK","Добре");
        llenguatges.Add("RUS-OK","ОК");

        llenguatges.Add("VAL-Ferramentes","Ferramentes");
        llenguatges.Add("ESP-Ferramentes","Herramientas");
        llenguatges.Add("ENG-Ferramentes","Tools");
        llenguatges.Add("ROM-Ferramentes","Scule");
        llenguatges.Add("UKR-Ferramentes","Інструменти");
        llenguatges.Add("RUS-Ferramentes","Инструменты");

        llenguatges.Add("VAL-Escaner","Escanejar");
        llenguatges.Add("ESP-Escaner","Escanear");
        llenguatges.Add("ENG-Escaner","Scan");
        llenguatges.Add("ROM-Escaner","Scanare");
        llenguatges.Add("UKR-Escaner","Відсканувати");
        llenguatges.Add("RUS-Escaner","Сканировать");

        llenguatges.Add("VAL-Passaport","Passaport");
        llenguatges.Add("ESP-Passaport","Pasaporte");
        llenguatges.Add("ENG-Passaport","Passport");
        llenguatges.Add("ROM-Passaport","Pașaport");
        llenguatges.Add("UKR-Passaport","Паспорт");
        llenguatges.Add("RUS-Passaport","Паспорт");
        
        llenguatges.Add("VAL-Masculí","Masculí");
        llenguatges.Add("ESP-Masculí","Masculino");
        llenguatges.Add("ENG-Masculí","Male");
        llenguatges.Add("ROM-Masculí","Masculin");
        llenguatges.Add("UKR-Masculí","Чоловічий");
        llenguatges.Add("RUS-Masculí","Мужской");
        
        llenguatges.Add("VAL-Femení","Femení");
        llenguatges.Add("ESP-Femení","Femenino");
        llenguatges.Add("ENG-Femení","Female");
        llenguatges.Add("ROM-Femení","Femenin");
        llenguatges.Add("UKR-Femení","Жіноча");
        llenguatges.Add("RUS-Femení","Женский");

        llenguatges.Add("VAL-Estandar","Estandar");
        llenguatges.Add("ESP-Estandar","Estandar");
        llenguatges.Add("ENG-Estandar","Standar");
        llenguatges.Add("ROM-Estandar","Standard");
        llenguatges.Add("UKR-Estandar","Стандартний");
        llenguatges.Add("RUS-Estandar","Стандартный");

        llenguatges.Add("VAL-Orelles","Orellut");
        llenguatges.Add("ESP-Orelles","Orejudo");
        llenguatges.Add("ENG-Orelles","Big-eared");
        llenguatges.Add("ROM-Orelles", "Urecheat");
        llenguatges.Add("UKR-Orelles","Вухатий");
        llenguatges.Add("RUS-Orelles","Ушастий");

        llenguatges.Add("VAL-Banya","Banya Trencada");
        llenguatges.Add("ESP-Banya","Cuerno Roto");
        llenguatges.Add("ENG-Banya","Broken Horn");
        llenguatges.Add("ROM-Banya","Cornu Rupt");
        llenguatges.Add("UKR-Banya","Зламаний Ріг");
        llenguatges.Add("RUS-Banya","Сломанный Рог");

        llenguatges.Add("VAL-Curta","Trompa curta");
        llenguatges.Add("ESP-Curta","Trompa corta");
        llenguatges.Add("ENG-Curta","Short Trunk");
        llenguatges.Add("ROM-Curta","Trompă scurtă");
        llenguatges.Add("UKR-Curta","Короткий Хобот");
        llenguatges.Add("RUS-Curta","Короткий Хобот");

        llenguatges.Add("VAL-Roig","Roig");
        llenguatges.Add("ESP-Roig","Rojo");
        llenguatges.Add("ENG-Roig","Red");
        llenguatges.Add("ROM-Roig","Roșu");
        llenguatges.Add("UKR-Roig","Червоний");
        llenguatges.Add("RUS-Roig","Красный");

        llenguatges.Add("VAL-Verd","Verd");
        llenguatges.Add("ESP-Verd","Verde");
        llenguatges.Add("ENG-Verd","Green");
        llenguatges.Add("ROM-Verd","Verde");
        llenguatges.Add("UKR-Verd","Зелений");
        llenguatges.Add("RUS-Verd","Зеленый");

        llenguatges.Add("VAL-Groc","Groc");
        llenguatges.Add("ESP-Groc","Amarillo");
        llenguatges.Add("ENG-Groc","Yellow");
        llenguatges.Add("ROM-Groc","Galben");
        llenguatges.Add("UKR-Groc","Жовтий");
        llenguatges.Add("RUS-Groc","Желтый");

        llenguatges.Add("VAL-Morat","Morat");
        llenguatges.Add("ESP-Morat","Morado");
        llenguatges.Add("ENG-Morat","Purple");
        llenguatges.Add("ROM-Morat","Mov");
        llenguatges.Add("UKR-Morat","Фіолетовий");
        llenguatges.Add("RUS-Morat","Фиолетовый");

        llenguatges.Add("VAL-Negre","Negre");
        llenguatges.Add("ESP-Negre","Negro");
        llenguatges.Add("ENG-Negre","Black");
        llenguatges.Add("ROM-Negre","Negru");
        llenguatges.Add("UKR-Negre","Чорни");
        llenguatges.Add("RUS-Negre","Черный");

        llenguatges.Add("VAL-Rosa","Rosa");
        llenguatges.Add("ESP-Rosa","Rosa");
        llenguatges.Add("ENG-Rosa","Pink");
        llenguatges.Add("ROM-Rosa","Roz");
        llenguatges.Add("UKR-Rosa","Рожевий");
        llenguatges.Add("RUS-Rosa","Розовый");

        llenguatges.Add("VAL-Flac","Flac");
        llenguatges.Add("ESP-Flac","Flaco");
        llenguatges.Add("ENG-Flac","Thin");
        llenguatges.Add("ROM-Flac","Slab");
        llenguatges.Add("UKR-Flac","Худий");
        llenguatges.Add("RUS-Flac","Худой");

        llenguatges.Add("VAL-Gros","Gros");
        llenguatges.Add("ESP-Gros","Gordo");
        llenguatges.Add("ENG-Gros","Fat");
        llenguatges.Add("ROM-Gros","Gras");
        llenguatges.Add("UKR-Gros","Товстий");
        llenguatges.Add("RUS-Gros","Толстый");

        llenguatges.Add("VAL-Pelut","Pelut");
        llenguatges.Add("ESP-Pelut","Peludo");
        llenguatges.Add("ENG-Pelut","Hairy");
        llenguatges.Add("ROM-Pelut","Păros");
        llenguatges.Add("UKR-Pelut","Пухнастий");
        llenguatges.Add("RUS-Pelut","Пушистый");

        
        llenguatges.Add("VAL-Tronc","Amb Tronc");
        llenguatges.Add("ESP-Tronc","Con Tronco");
        llenguatges.Add("ENG-Tronc","With Log");
        llenguatges.Add("ROM-Tronc","Cu Trunchi");
        llenguatges.Add("UKR-Tronc","Стовбуристий");
        llenguatges.Add("RUS-Tronc","Столбуристый");

        llenguatges.Add("VAL-champi","Xampinyó");
        llenguatges.Add("ESP-champi","Champiñón");
        llenguatges.Add("ENG-champi","White Mushroom");
        llenguatges.Add("ROM-champi","Ciupercă");
        llenguatges.Add("UKR-champi","Гриб");
        llenguatges.Add("RUS-champi","Гриб");

        llenguatges.Add("VAL-multiple","Multiple");
        llenguatges.Add("ESP-multiple","Multiple");
        llenguatges.Add("ENG-multiple","Multiple");
        llenguatges.Add("ROM-multiple","Multiplu");
        llenguatges.Add("UKR-multiple","Множинний");
        llenguatges.Add("RUS-multiple","Множественный");


        llenguatges.Add("VAL-Treball","Permís de treball");
        llenguatges.Add("ESP-Treball","Permiso de trabajo");
        llenguatges.Add("ENG-Treball","Working Permit");
        llenguatges.Add("ROM-Treball","Permis de lucru");
        llenguatges.Add("UKR-Treball","Дозвіл на роботу");
        llenguatges.Add("RUS-Treball","Разрешение на работу");

        llenguatges.Add("VAL-PCR","PCR");
        llenguatges.Add("ESP-PCR","PCR");
        llenguatges.Add("ENG-PCR","PCR");
        llenguatges.Add("ROM-PCR","PCR");
        llenguatges.Add("UKR-PCR","ПЛР Тест");
        llenguatges.Add("RUS-PCR","ПЛР Тест");

        llenguatges.Add("VAL-Infinit","Infinit");
        llenguatges.Add("ESP-Infinit","Infinito");
        llenguatges.Add("ENG-Infinit","Infinit");
        llenguatges.Add("ROM-Infinit","Infinit");
        llenguatges.Add("UKR-Infinit","Безкінченний");
        llenguatges.Add("RUS-Infinit","Безконечный");

        llenguatges.Add("VAL-Intro","Benvingut al control aduaner de La Unió Galàctica. Hui dia 30/01/2321, començarà la teua feina. Has de comprovar que tot aquell que vinga a la frontera duga un passaport vàlid, És a dir, no estiga caduc i concorde amb el visitant.");
        llenguatges.Add("ESP-Intro","Bienvenido al control de aduanas de La Unión Galáctica. Hoy dia 30/01/2321 empezara tu trabajo. Has de comprobar que todo aquel que venga a la frontera lleve un pasaporte válido, És decir, que no esté caducado y que concuerde con el visitante.");
        llenguatges.Add("ENG-Intro","Welcome to Galactic Union's custom control. Today 30/01/2321 your work will start. You must check that everyone who comes to the border has a valid passport, that is to say, it is not expired and it matches the visitor.");
        llenguatges.Add("ROM-Intro","Bine a-ți venit la vama de la Uniunea Galactică. Astăzi 30/01/2321 va începe lucrul tau. Trebuie să verifici că ori cine vine la frontieră are un pașaport valabil. Mai bine zis, să nu fie expirat și să fie in conformitate cu vizitatoru.");
        llenguatges.Add("UKR-Intro","Ласкаво просимо до таможньої Галактичного Союзу. Сьогодні, 30го 01го 2321го, почнеться твоя робота. Ти повинен перевіряти дійсність паспорту у усіх хто пройде через кордон");
        llenguatges.Add("RUS-Intro","Добро пожаловать на таможню Галактического Союза. Сегодня, 30го 01го 2321го, начнется твоя работа. Ты должен проверять действительность паспорта у всех кто пройдет через границу");

        llenguatges.Add("VAL-Intro2","Les Tribus Mammutidànies han fet un pacte amb La Unió Galàctica. D'ara en avant els seus ciutadans poden creuar la frontera al igual que els nostres. Aquest es el seu aspecte:");
        llenguatges.Add("ESP-Intro2","Las Tribus Mammuticánias han hecho un pacto con La Unión Galáctica. De ahora en adelante sus ciudadanos pueden cruzar la frontera al igual que los nuestros. Este es su aspecto:");
        llenguatges.Add("ENG-Intro2","The Mammutidanie Tribe has made an agreement with the Galactic Union. From now on their citizens can cross our borders as well as ours. This is their appearence:");
        llenguatges.Add("ROM-Intro2","Triburile Mammutidanie au ajuns la o înțelegere cu Uniunea Galactică. De acuma înainte cetățenii lor poate să treacă frontira la fel ca cetățenii noștri. Asa arată ei:");
        llenguatges.Add("UKR-Intro2","Маммудитаньсі Племена уклали договір з Галактичним Союзом. Відтепер їхні громадяни можуть перетинати кордон так само як і наші. Це їхній вигляд:");
        llenguatges.Add("RUS-Intro2","Маммудитанские Племена заключили договор с Галактическим Союзом. От теперь их граждане могут пересекать кордон так же как и наши. Это их вид:");

        llenguatges.Add("VAL-Intro3","La Republica Binaria d'Osmium s'ha interesat en nosaltres. D'ara en avant els seus ciutadans podrán creuar la frontera. A més a més, D'ara en avant aquells que vulguen treballar han de aportar un permís valid.");
        llenguatges.Add("ESP-Intro3","La República Binaria de Osmium se ha interesado en nosotros. De ahora en adelante sus ciudadanos pueden cruzar la frontera. Además, desde ahora aquellos que quieran trabajar deben aportar un permiso válido.");
        llenguatges.Add("ENG-Intro3","The Binary Republic of Osmium has been interested in us. From now on their citizens can cross our border. Additionally, from now on those who want to work must provide a valid petmit.");
        llenguatges.Add("ROM-Intro3", "Cei de la Republica Binarie de Osmium sau interesat de noi. De acuma înainte cetățenii lor poate să treacă frontiera. La fel, cei ce vor să lucreze de acuma in ainte trebuie să aducă un permis în vigoare.");
        llenguatges.Add("UKR-Intro3","Осміумська Бінарна Республіка проявила до нас інтерес. Відтепер їхні громадяни можуть перетинати кордон. Також, відтепер ті хто хочуть у нас працювати повинні пред’явити дозвіл на роботу");
        llenguatges.Add("RUS-Intro3","Осмиумская Бинарная Республика проявила к нам интерес. Отныне их граждане могут пересекать границу. Также, теперь те кто хотят у нас работать должны предъявить разрешение на работу");

        llenguatges.Add("VAL-Intro4","La teocràcia de Redempció ha fet un pacte amb nosaltres. Els seus ciutadans son Benvinguts");
        llenguatges.Add("ESP-Intro4","La teocrácia de Redención ha hecho un pacto con nosotros. Sus ciudadanos son bienvenidos.");
        llenguatges.Add("ENG-Intro4","The Redemption Theocracy has made an agreement with us. Their citizens are welcome.");
        llenguatges.Add("ROM-Intro4", "Cei din Teocrație Răscumpărării a ajuns la o înțelegere cu noi. Cetățenii lor sunt bine veniți.");
        llenguatges.Add("UKR-Intro4","Теократія Спасіння підписала з нами договір. Ласкаво запрошуємо їхніх громадян до нас");
        llenguatges.Add("RUS-Intro4","Теократия Спасение подписала с нами договор. Приглашаем их граждан к нам");

        llenguatges.Add("VAL-Intro5","La colmena ha fet un pacte amb nosaltres. Els seus ciutadans son Benvinguts. L'imperi ha decidit que tot aquell que siga Xenófob, Elitista, Vengatiu o Codiciós no podrá pasar. Fes Escaners per averiguar-ho");
        llenguatges.Add("ESP-Intro5","La colmena ha hecho un pacto con nosotros. Sus ciudadanos son bienvenidos. El imperio ha decidido que todo aquel que sea Xenofobo, Elitista, Vengativo o Codicioso no podrá pasar. Haz escaners para averiguarlo.");
        llenguatges.Add("ENG-Intro5","The hive has made an agreement with us. Their citizens are welcome. The empire has decided that everyone who is Xenophobic, Elitist, Vengeful or Greedy will not be able to pass. Do scanners to find out.");
        llenguatges.Add("ROM-Intro5", "Stupul a ajuns la o înțelegere cu noi. Cetățenii lor sunt bine veniți. Imperiul a decis că toți cei care sunt Xenofobi, Elitisti, răzbunători sau lacomi nu vor putea trece. Sacnează-i ca să descoperi.");
        llenguatges.Add("UKR-Intro5","Вулик підписав з нами договір. Імперія вимагає не пропускати будь-кого хто виявиться Ксенофобом, Елітарним, Мстивим або Жадібним. Щоб це визначити, використовуй сканер");
        llenguatges.Add("RUS-Intro5","Улей подписал с нами договор. Империя требует не пропускать любого кто окажется Ксенофобом, Элитарным, Мстительным или Жадным. Чтобы это определить, используй сканер");

        llenguatges.Add("VAL-Intro6","Els Fungidae han fet un pacte amb nosaltres. Son Benvinguts.");
        llenguatges.Add("ESP-Intro6","Los Fungidae han hecho un pacto con nosotros. Son bienvenidos.");
        llenguatges.Add("ENG-Intro6","The Fungidae has made an agreement with us. They are welcome.");
        llenguatges.Add("ROM-Intro6","Cei din Fungidae a ajuns la o înțelegere cu noi. Sunt bine veniți.");
        llenguatges.Add("UKR-Intro6","Грибоподібні підписали з нами договір. Ласкаво просимо");
        llenguatges.Add("RUS-Intro6","Грибовидные подписали с нами договор. Милости просим");

        llenguatges.Add("VAL-Intro7","L'imperi Varanu s'ha sumat a obrir les fronteres amb nosaltres.");
        llenguatges.Add("ESP-Intro7","El imperio Varanu se ha sumado a abrir las fronteras con nosotros.");
        llenguatges.Add("ENG-Intro7","The Varanu Empire has joined in opening the borders with us.");
        llenguatges.Add("ROM-Intro7", "Impreiul Varanu s-a alăturat noua și-a deschis frontierele.");
        llenguatges.Add("UKR-Intro7","Імперія Варану погодилася відкрити з нами кордони");
        llenguatges.Add("RUS-Intro7","Империя Варану согласилась открыть с нами границы");

        llenguatges.Add("VAL-Intro8","Un virus s'ha escampat per el espai. Realitza PCRs i no permetis la entrada a ningún malalt");
        llenguatges.Add("ESP-Intro8","Un virus se ha esparcido por el espacio. Realiza PCRs y no permitas la entrada a ningún enfermo.");
        llenguatges.Add("ENG-Intro8","A virus has spread through space. Perform PCR and do not allow the entry to any sick.");
        llenguatges.Add("ROM-Intro8", "Un virus s-a răspandit în spațiu. Realizează PCR și nu permite să intre nimeni bolnav.");
        llenguatges.Add("UKR-Intro8","Через космос розповсюджується вірус. Проводь ПЛР тести і не дозволь пройти нікому інфікованому");
        llenguatges.Add("RUS-Intro8","Через космос распространяется вирус. Проводи ПЦР тесты и не позволь пройти никому инфицированному.");

        llenguatges.Add("VAL-Intro9","Ben fet, no hi ha cap novetat");
        llenguatges.Add("ESP-Intro9","Bien hecho, no hay ninguna novedad.");
        llenguatges.Add("ENG-Intro9","Well done, there is no news.");
        llenguatges.Add("ROM-Intro9","Bine făcut, nu ai nici o noutate.");
        llenguatges.Add("UKR-Intro9","Хороша робота, без новин");
        llenguatges.Add("RUS-Intro9","Хорошая работа, без новостей");

        llenguatges.Add("VAL-Intro10","Ben fet, no hi ha cap novetat");
        llenguatges.Add("ESP-Intro10","Bien hecho, no hay ninguna novedad.");
        llenguatges.Add("ENG-Intro10","Well done, there is no news.");
        llenguatges.Add("ROM-Intro10","Bine făcut, nu ai nici o noutate.");
        llenguatges.Add("UKR-Intro10","Хороша робота, без новин");
        llenguatges.Add("RUS-Intro10","Хорошая работа, без новостей");

        llenguatges.Add("VAL-Intro11","Enhorabona!, has acabat el mode Historia. Mode infinit desbloquejat.");
        llenguatges.Add("ESP-Intro11","¡Enhorabuena!, has terminado el modo Historia. Modo infinito desbloqueado.");
        llenguatges.Add("ENG-Intro11","Congratulations! you finished Story mode. Infinite mode has been unlocked.");
        llenguatges.Add("ROM-Intro11","Felicitări!, ai terminat modul Istoria. Modul infinit deblocat.");
        llenguatges.Add("UKR-Intro11","Поздоровляємо! Ви закінчили історію. Ви розблокували безкінечну гру");
        llenguatges.Add("RUS-Intro11","Поздравляем! Вы закончили историю. Вы разблокировали бесконечною игру");

        llenguatges.Add("VAL-Puntuació","La teua puntuació és:");
        llenguatges.Add("ESP-Puntuació","Tu puntuación és:");
        llenguatges.Add("ENG-Puntuació","Your score is:");
        llenguatges.Add("ROM-Puntuació","Punctajul tău este:");
        llenguatges.Add("UKR-Puntuació","Ваші бали:");
        llenguatges.Add("RUS-Puntuació","Ваши баллы");

        llenguatges.Add("VAL-Nom","Introdueix el teu nom");
        llenguatges.Add("ESP-Nom","Introduce tu nombre");
        llenguatges.Add("ENG-Nom","Enter your name");
        llenguatges.Add("ROM-Nom","Introduce numele tău");
        llenguatges.Add("UKR-Nom","Введіть ваше ім‘я");
        llenguatges.Add("RUS-Nom","Введите ваше имя");

        llenguatges.Add("VAL-Puntuacions","Puntuacions");
        llenguatges.Add("ESP-Puntuacions","Puntuaciones");
        llenguatges.Add("ENG-Puntuacions","Score");
        llenguatges.Add("ROM-Puntuacions","Punctaj");
        llenguatges.Add("UKR-Puntuació","Ваші бали:");
        llenguatges.Add("RUS-Puntuació","Ваши баллы");

        llenguatges.Add("VAL-Xeno","Xenòfob");
        llenguatges.Add("ESP-Xeno","Xenofobo");
        llenguatges.Add("ENG-Xeno","Xenophobic");
        llenguatges.Add("ROM-Xeno","Xenofob");
        llenguatges.Add("UKR-Xeno","Ксенофоб");
        llenguatges.Add("RUS-Xeno","Ксенофоб");

        llenguatges.Add("VAL-Elitista","Elitista");
        llenguatges.Add("ESP-Elitista","Elitista");
        llenguatges.Add("ENG-Elitista","Elitist");
        llenguatges.Add("ROM-Elitista","Elitist");
        llenguatges.Add("UKR-Elitista","Елітарний");
        llenguatges.Add("RUS-Elitista","Элитарный");

        llenguatges.Add("VAL-Vengatiu","Vengatiu");
        llenguatges.Add("ESP-Vengatiu","Vengativo");
        llenguatges.Add("ENG-Vengatiu","Vengeful");
        llenguatges.Add("ROM-Vengatiu", "Răzbunător");
        llenguatges.Add("UKR-Vengatiu","Мстивий");
        llenguatges.Add("RUS-Vengatiu","Мстительный");

        llenguatges.Add("VAL-Codicios","Codicios");
        llenguatges.Add("ESP-Codicios","Codicioso");
        llenguatges.Add("ENG-Codicios","Greedy");
        llenguatges.Add("ROM-Codicios","Lacom");
        llenguatges.Add("UKR-Codicios","Жадібний");
        llenguatges.Add("RUS-Codicios","Жадный");
    }

}
