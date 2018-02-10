using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomdatagen
{
	public partial class Form1 : Form
	{
		List<int> tanárok = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
		string[] tables = new string[] {
			"terem_allapot_ref",
			"magaviselet_tipus",
			"csaladtagok",
			"naplo_bejegyzesek",
			"osztalytermek",
			"uzenetek",
			"tanarok",
			"diakok",
			"osztalyok"
		};
		Dictionary<string, string> columns = new Dictionary<string, string>() {
			{"terem_allapot_ref"    ,"id,megnevezes,leiras"},
			{"magaviselet_tipus"    ,"id,megnevezes,leiras"},
			{"csaladtagok"          ,"id,diak,nev,kapcsolat"},
			{"naplo_bejegyzesek"    ,"id,ora,tanar,diak,jegy,megjegyzes"},
			{"osztalytermek"        ,"id,emelet,ajto,allapot,megjegyzes"},
			{"uzenetek"             ,"id,tanar,diak,uzenet"},
			{"tanarok"              ,"id,nev,nem,osztaly_fonok,megjegyzes"},
			{"diakok"               ,"id,nev,csalad_nev,uto_nev,szuletesi_nev,nem,anyja_neve,szuletesi_datum,szuletesi_hely,szig_szam,osztaly,magaviselet,megjegyzes"},
			{"osztalyok"            ,"id,osztaly_fonok,osztaly_terem,megjegyzes"}
		};

		string[] uzenetek = new string[] { "Órán pékáruval dobálta társát. Megintem.", "Órán társa hátára minősíthetetlen feliratot ragasztott.", "Szünetben a fűtőtesten ült", "Órán bámulta a plafont.", "Körzőjével veszélyeztette társai testi épségét", "A gyerek az órán beszél, és állandóan jelentkezik", "A gyerek a szünetben az iskola keretein kívül játszott", "Tisztelt szülők! Fiuk az ebédlőben nemi szervét étkezési célokra ajánlotta fel, ezért megintem.", "Modortalan viselkedéséért megintem (A helyettesítőtanárt meglátva hangos öklendezésbe kezdett.)", "Órán rendetlen voltam, tiszteletlenül beszéltem", "Elkobozta társa tízóraiját", "Kedves Szülő! Csúnya beszédért osztályfőnöki figyelmeztetésben részesítem!", "T. Szülők! A tanórára gyíkot hozott be az udvarról, ami a tanteremben 'kiszabadult' a táskájából! Kérném elbeszélgetni a gyermekkel! [Ezzel ugyanis az órát zavarta]", "Tisztelt Szülők! Fiúk német órán több alkalommal hozzáért a tanárnőhöz és erotikus megjegyzéseket tett. Ezért osztályfőnöki rovóban részesítem. Kérem beszélgessenek el vele erről és értessék meg vele, hogy ne fogdossa a tanárnőt", "Tisztelt szülők! Fiuk az órákon rendszeresen gusztustalankodik, és kulturálatlan viselkedését hőstettként éli meg, holott zavarja társait, az órát. Kérem figyelmeztessék a közösségi élet általános szabályaira, mert ennek hiányában nem méltó az iskolánkhoz.", "Tisztelt Szülők! Lányuk az utcasarkon egy szál pólóban cigizik. Meg fog fázni.", "Az osztályfőnöki dicséretet még mindig nem íratta alá. Megintem.", "Kémia órán a kísérleti anyagot elfogyasztotta.", "Gyermeke az órámon írószer nélkül akart írni.", "Kémiaóra folyamán padtársával zümmögött és brummogott.", "Gyermekük óra alatt orvul elfogyasztotta padtársa uzsonnáját.", "Két ellenőrzője van. Én mosom kezeimet. – Osztályfőnök.", "Fia olvashatatlanul ír. Bár párszor még így jár jobban.", "Kesztyűben ül az órán, mert fázik a keze és nem írja a szavakat.", "Óra alatt kukorékolt!", "A gyerek a szünetben az iskola keretein kívül játszott.", "A gyerek az órán beszél, és állandóan jelentkezik.", "Körzőjével veszélyeztette társai testi épségét", "Elkobozta társa tízóraiját", "Fia óra alatt a pad sarkával jéghokisat játszott a terem körül, eközben MÁV bemondásokat tartott, melyben a rólam elnevezett szerelvény közeledtére figyelmeztetett", "Kedves szülő, ha megígéri, hogy nem hiszi el mindazt amit a fia az iskoláról mesél, én cserébe nem hiszem el mindazt, amit ő az otthoni eseményekről mond.", "Gyermekük matekórán a zsiráf hangját utánozta.", "Szellemessége és feltűnési viszketegsége a pofátlanság határait súrolja.", "Fia a szünetben sztrájkot szervezett. Letörtük.", "Nem elég, hogy a szünetekben állandóan krétacsatákat vív osztálytársaival, ráadásul mindig veszít.", "Tűvel látta el barátait, hogy osztálytársait szurkálják.", "Gyermeke azt mondta, hogy szerinte jó gondolat lenne az egyik osztálytársát bántalmazni, ezért figyelmeztetem.", "T. Szülő, a gyereke állandóan tőlem kér tollat. Lássa el otthon írószerrel.", "Tájékoztatom, hogy gyerekének egy ideje átható kénszaga van." };

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rb_Student.Checked)
			{
				genStudents((int)numericUpDown1.Value);
			}
			else if (rb_Teacher.Checked)
			{
				genTeachers((int)numericUpDown1.Value);
			}
			else if (rb_AllData.Checked)
			{
				generateData();
			}
		}

		public void generateData()
		{
			int teach = 20;
			int stud = 200;

			generateTables();
			genTeachers(teach);
			genStudents(stud);

			lbl_info.Text = "Generated all data. Table structure, base data, " + teach + " teachers and " + stud + " students.";
		}

		public void genTeachers(int val)
		{
			tanárok.Clear();
			if(val < 10) { val = 10; }

			List<int> ofők = new List<int>();

			for (int i = 0; i < val; i++)
			{
				Thread.Sleep(10);
				int gender = genRandom(0,2,3+i);
				string name = names.getName(gender);
				Thread.Sleep(5);
				int osztalyfonok = i < 10 ? 1 : 0;

				tanárok.Add(i + 1);

				if(osztalyfonok == 1) { ofők.Add(i); }

				richTextBox1.Text += string.Format("INSERT INTO tanarok (id,nev,nem,osztaly_fonok) VALUES ({0},'{1}',{2},{3}); \r\n",
					i + 1,
					name,
					gender,
					osztalyfonok
					);

				lbl_info.Text = (i + 1) + " teachers";
				lbl_info.Refresh();
			}

			List<int> otermek = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			for(int i = 0; i < 10; i++)
			{
				int t = genRandom(0, otermek.Count);
				int teremRand = otermek[t];
				otermek.Remove(teremRand);

				richTextBox1.Text += string.Format("INSERT INTO osztalyok (osztaly_fonok,osztaly_terem,megjegyzes) VALUES ({0},{1},'{2}'); \r\n",
					ofők[i],
					teremRand,
					"-"
					);
			}
		}

		public void genStudents(int val)
		{
			for (int i = 0; i < val; i++)
			{
				Thread.Sleep(2);
				int gender = genRandom(0, 2);
				string[] n = names.getNames(gender);
				string originalName = "";
				Thread.Sleep(2);
				if (genRandom(0,1001) > 900) { originalName = n[0].Split(' ')[0] + " " + names.getName(gender).Split(' ')[1]; }
				Thread.Sleep(2);
				int szul_ev = genRandom(1990, 2000, 10);
				int szul_ho = genRandom(1, 13, 10);
				int szul_nap = genRandom(1, 31, 20); 
				int osztaly = 2000 - szul_ev;
				Thread.Sleep(2);
				string szletesi_hely = names.varosok[genRandom(0, names.varosok.Length, 100)];
				int magaviselet = genRandom(1, 6, 999);

				//todo: fix rokon

				int rokon = genRandom(0, 1001);
				string apa = "";

				if(genRandom(0, 1001) > 300) { apa = n[0].Split(' ')[0] + " " + names.fiunevek[genRandom(0, names.fiunevek.Length, 865)]; }
				List<string> testverek = new List<string>();

				int numOfSiblings = (genRandom(-1,6,1) + genRandom(-1, 6, 10) + genRandom(-1, 6, 100)) / 3;
				if(numOfSiblings > 0)
				{
					for(int ii = 0; ii < numOfSiblings; ii++)
					{
						Thread.Sleep(10);
						testverek.Add(n[0].Split(' ')[0] + " " + (genRandom(0, 2, 52) == 0 ? names.fiunevek[genRandom(0, names.fiunevek.Length, Environment.TickCount + 100)] : names.lanynevek[genRandom(0, names.lanynevek.Length, 150)]));
					}
				}

				
				List<string> nagyszulok = new List<string>();
				Thread.Sleep(10);
				if (genRandom(0, 11, 11) > 5) { nagyszulok.Add(n[0].Split(' ')[0] + " " + names.fiunevek[genRandom(0, names.fiunevek.Length, 20776)]); } //Apai nagyapa
				Thread.Sleep(10);
				if (genRandom(0, 11, 12) > 5) { nagyszulok.Add(names.getName(1, "")); } // Apai nagyanya
				Thread.Sleep(10);
				if (genRandom(0, 11, 13) > 5) { nagyszulok.Add(n[1].Split(' ')[0] + " " + names.fiunevek[genRandom(0, names.fiunevek.Length, 23497)]); } //Anyai nagyapa
				Thread.Sleep(10);
				if (genRandom(0, 11, 14) > 5) { nagyszulok.Add(names.getName(1, "")); } //Anyai nagyanya


				richTextBox1.Text += string.Format("INSERT INTO diakok (id,nev,csalad_nev,uto_nev,szuletesi_nev,nem,anyja_neve,szuletesi_datum,szuletesi_hely,szig_szam,osztaly,magaviselet) VALUES ({11},'{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}',{9},{10}); \r\n",
					n[0],
					n[0].Split(' ')[0],
					n[0].Split(' ')[1],
					originalName,
					(gender + 1),
					n[1],
					szul_ev + "." + szul_ho + "." + szul_nap + ".",
					szletesi_hely,
					generateszigszam(),
					osztaly,
					magaviselet,
					i
					);

				if (apa != "") { richTextBox1.Text += string.Format("INSERT INTO csaladtagok (diak, nev, kapcsolat) VALUES ({0},'{1}',{2});\r\n", i, apa, "1"); }
				richTextBox1.Text += string.Format("INSERT INTO csaladtagok (diak, nev, kapcsolat) VALUES ({0},'{1}',{2});\r\n", i, n[1], "1");

				foreach (string s in testverek)
				{
					richTextBox1.Text += string.Format("INSERT INTO csaladtagok (diak, nev, kapcsolat) VALUES ({0},'{1}',{2}); -- testver \r\n", i, s, "3");
				}

				foreach (string s in nagyszulok)
				{
					richTextBox1.Text += string.Format("INSERT INTO csaladtagok (diak, nev, kapcsolat) VALUES ({0},'{1}',{2}); -- nagyszulo \r\n", i, s, "5");
				}

				int jegyek = genRandom(3, 20, 9872345);
				for(int j = 0; j < jegyek; j++)
				{
					Thread.Sleep(5);
					int ora = genRandom(1, 13, 888);
					Thread.Sleep(5);
					int jegy = genRandom(1, 6, 18181 + j);
					Thread.Sleep(5);
					int tanar = tanárok[genRandom(0, tanárok.Count,1214)];

					richTextBox1.Text += string.Format("INSERT INTO naplo_bejegyzesek (ora,tanar,diak, jegy) VALUES ({0},{1},{2},{3}); \r\n", ora, tanar, i, jegy);
				}

				if(genRandom(0,1001) > 800)
				{
					Thread.Sleep(5);
					int tanar = tanárok[genRandom(0, tanárok.Count, 1214)];
					string uzenet = string.Format("INSERT INTO uzenetek (tanar,diak,uzenet) VALUES ({0},{1},'{2}'); -- üzenet\r\n", tanar, i, uzenetek[genRandom(0, uzenetek.Length)]);
					richTextBox1.Text += uzenet;
				}

				lbl_info.Text = (i + 1) + " students";
				lbl_info.Refresh();
			}

			
		}

		public int genRandom(int min, int max) { return genRandom(min, max, 0); }
		public int genRandom(int min, int max, int seed)
		{
			return new Random(Environment.TickCount + seed).Next(min, max);
		}

		public string generateszigszam()
		{
			Thread.Sleep(2);
			return new Random().Next(100000,999999).ToString() + names.betuk[new Random(Environment.TickCount - 10009).Next(0,names.betuk.Length)] + names.betuk[new Random(Environment.TickCount).Next(0, names.betuk.Length)] + "";
		}

		private void btn_GenTables_Click(object sender, EventArgs e)
		{
			generateTables();
		}

		public void generateTables()
		{
			lbl_info.Text = "Table Structure and base data.";

			richTextBox1.Text = @"
CREATE TABLE `terem_allapot_ref` (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`megnevezes`	TEXT NOT NULL,
	`leiras`	TEXT DEFAULT 'Nincs Leírás'
);
CREATE TABLE `orak` (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`ora_neve`	TEXT NOT NULL
);
CREATE TABLE magaviselet_tipus (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`megnevezes`	INTEGER,
	`leiras`	INTEGER
);
CREATE TABLE csaladtagok (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`diak`	INTEGER,
	`nev`	TEXT,
	`kapcsolat`	INTEGER,
	FOREIGN KEY(`diak`) REFERENCES `diakok`(`id`),
	FOREIGN KEY(`kapcsolat`) REFERENCES rokon_tipus(id)
);
CREATE TABLE `rokon_tipus` (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`kapcsolat`	TEXT
);
CREATE TABLE naplo_bejegyzesek (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`ora`	INTEGER,
	`tanar`	INTEGER,
	`diak`	INTEGER,
	`jegy`	INTEGER NOT NULL DEFAULT 3,
	`megjegyzes`	INTEGER,
	FOREIGN KEY(`ora`) REFERENCES `orak`(`id`),
	FOREIGN KEY(`tanar`) REFERENCES `tanarok`(`id`),
	FOREIGN KEY(`diak`) REFERENCES `diakok`(`id`)
);
CREATE TABLE osztalytermek (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`emelet`	INTEGER NOT NULL,
	`ajto`	INTEGER NOT NULL,
	`allapot`	INTEGER NOT NULL,
	`megjegyzes`	TEXT,
	FOREIGN KEY(`allapot`) REFERENCES `terem_allapot_ref`(`id`)
);
CREATE TABLE uzenetek (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`tanar`	INTEGER,
	`diak`	INTEGER,
	`uzenet`	TEXT,
	FOREIGN KEY(`tanar`) REFERENCES `tanarok`(`id`)
);
CREATE TABLE `nemek` (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`nem`	TEXT
);
CREATE TABLE tanarok (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`nev`	TEXT NOT NULL,
	`nem`	INTEGER NOT NULL DEFAULT 0,
	`osztaly_fonok`	INTEGER NOT NULL DEFAULT 0,
	`megjegyzes`	TEXT,
	FOREIGN KEY(`nem`) REFERENCES nemek(id)
);
CREATE TABLE diakok (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`nev`	TEXT NOT NULL,
	`csalad_nev`	TEXT,
	`uto_nev`	TEXT,
	`szuletesi_nev`	TEXT,
	`nem`	INTEGER,
	`anyja_neve`	TEXT NOT NULL,
	`szuletesi_datum`	TEXT NOT NULL,
	`szuletesi_hely`	TEXT NOT NULL,
	`szig_szam`	TEXT NOT NULL,
	`osztaly`	INTEGER NOT NULL,
	`magaviselet`	INTEGER,
	`megjegyzes`	TEXT,
	FOREIGN KEY(`nem`) REFERENCES `nemek`(`id`),
	FOREIGN KEY(`osztaly`) REFERENCES `osztalyok`(`id`),
	FOREIGN KEY(`magaviselet`) REFERENCES `magaviselet_tipus`(`id`)
);
CREATE TABLE osztalyok (
	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`osztaly_fonok`	INTEGER NOT NULL,
	`osztaly_terem`	INTEGER NOT NULL,
	`megjegyzes`	TEXT,
	FOREIGN KEY(`osztaly_fonok`) REFERENCES tanarok(id),
	FOREIGN KEY(`osztaly_terem`) REFERENCES `osztalytermek`(`id`)
);
INSERT INTO terem_allapot_ref (id,megnevezes, leiras) VALUES (1,'Kíváló', 'A terem minden elvárásnak megfelel'); 
INSERT INTO terem_allapot_ref (id,megnevezes,leiras)  VALUES (2,'Hiányos', 'A terem jó állapotban van, de hiányos a felszereltsége');
INSERT INTO terem_allapot_ref (id,megnevezes,leiras)  VALUES (3,'Sérült', 'A teremben elhelyezett bútorok némelyike sérültm károsodott');
INSERT INTO terem_allapot_ref (id,megnevezes,leiras)  VALUES (4,'Tanításra alkalmatlan', 'A terem olyan mértékben károsodott, hogy az egészségre káros, vagy más okból a tanítás folytatására nem alkalmas');
INSERT INTO rokon_tipus(id, kapcsolat) VALUES(1, 'Édesszülő'); 
INSERT INTO rokon_tipus (id,kapcsolat) VALUES (2, 'Mostohaszülő');
INSERT INTO rokon_tipus (id,kapcsolat) VALUES (3, 'Édestestvér');
INSERT INTO rokon_tipus (id,kapcsolat) VALUES (4, 'Mostohatestvér');
INSERT INTO rokon_tipus (id,kapcsolat) VALUES (5, 'Nagyszülő');
INSERT INTO rokon_tipus (id,kapcsolat) VALUES (6, 'Egyéb');
INSERT INTO rokon_tipus (id,kapcsolat) VALUES (7, 'Nincs Kapcsolat');
INSERT INTO orak (id,ora_neve) VALUES (1, 'Magyar Nyelv');
INSERT INTO orak (id,ora_neve) VALUES (2, 'Irodalom');
INSERT INTO orak (id,ora_neve) VALUES (3, 'Matematika');
INSERT INTO orak (id,ora_neve) VALUES (4, 'Történelem');
INSERT INTO orak (id,ora_neve) VALUES (5, 'Kémia');
INSERT INTO orak (id,ora_neve) VALUES (6, 'Fizika');
INSERT INTO orak (id,ora_neve) VALUES (7, 'Angol Nyelv');
INSERT INTO orak (id,ora_neve) VALUES (8, 'Német Nyelv');
INSERT INTO orak (id,ora_neve) VALUES (9, 'Informatika');
INSERT INTO orak (id,ora_neve) VALUES (10, 'Rajz');
INSERT INTO orak (id,ora_neve) VALUES (11, 'Zene');
INSERT INTO orak (id,ora_neve) VALUES (12, 'Biológia');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (1, 0, 1, 2, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (2, 0, 2, 1, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (3, 0, 3, 1, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (4, 1, 11, 3, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (5, 1, 12, 2, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (6, 1, 13, 1, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (7, 1, 14, 2, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (8, 2, 21, 2, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (9, 2, 22, 1, '-');
INSERT INTO osztalytermek (id,emelet,ajto,allapot,megjegyzes) VALUES (10, 2, 23, 1, '-');
INSERT INTO nemek(id, nem) VALUES(1, 'Férfi'); 
INSERT INTO nemek (id,nem) VALUES (2, 'Nő');";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(richTextBox1.Text);
			lbl_info.Text = "Generated data copied to clipboard!";
		}

		private void btn_OpenClose_Click(object sender, EventArgs e)
		{
			if(richTextBox1.Right >= Width - 30)
			{
				richTextBox1.Width = btn_GenTables.Left - richTextBox1.Left;
				btn_OpenClose.Text = ">";
			}
			else
			{
				richTextBox1.Width = Width - 30 - richTextBox1.Left;
				btn_OpenClose.Text = "<";
			}
		}

		private string getRandomTable(List<string> tbls)
		{
			string t = tbls[new Random(Environment.TickCount + new Random().Next()).Next(0, tbls.Count)];
			tbls.Remove(t);

			return t;
		}

		private string getTableColumns(string table)
		{
			string ret = "";
			List<string> cols = columns[table].Split(',').ToList();
			int cc = cols.Count;
			for (int i = 0; i < new Random(Environment.TickCount + 33).Next(2, cc); i++)
			{
				Thread.Sleep(1);
				string r = cols[new Random(Environment.TickCount + 1 + Environment.TickCount / 2).Next(0, cols.Count)];
				ret += r + ", ";
				cols.Remove(r);
			}

			ret = ret.Trim(',',' ');

			return ret;
		}

		private string generateQuery(int type)
		{
			string ret = "";

			List<string> tbls = tables.ToList();

			for (int i = 0; i < new Random().Next(3, 7); i++)
			{
				Thread.Sleep(10);

				if (type == 1)
				{
					ret += "SELECT * FROM " + getRandomTable(tbls) + "; \r\n";
				}

				else if (type == 2)
				{
					string table = getRandomTable(tbls);
					ret += "SELECT " + getTableColumns(table) + " FROM " + table + "; \r\n";
				}
				else if (type == 3)
				{
					string table = getRandomTable(tbls);
					ret += "SELECT " + getTableColumns(table) + " FROM " + table + "; \r\n";
				}
			}






			return ret;
		}

		private void btn_CLICK(object sender, EventArgs e)
		{
			int t = 0;
			Int32.TryParse((sender as Button).Tag.ToString(), out t);
			
			if(t > 0)
			{
				switch (t)
				{
					case 1:
						richTextBox1.Rtf = Properties.Resources.simple_SELECT;
						richTextBox1.Text += generateQuery(1);
						break;


					case 2:
						richTextBox1.Rtf = Properties.Resources.specific_SELECT;
						richTextBox1.Text += generateQuery(2);
						break;


					case 3:
						richTextBox1.Rtf = Properties.Resources.WHERE_SELECT;
						richTextBox1.Text += generateQuery(3);
						break;


					case 4:
						richTextBox1.Rtf = Properties.Resources.LIMIT_ORDER_SELECT;
						richTextBox1.Text += generateQuery(4);
						break;


					case 5:
						richTextBox1.Rtf = Properties.Resources.SELECT_SUBSELECT;
						richTextBox1.Text += generateQuery(5);
						break;


					case 6:
						richTextBox1.Rtf = Properties.Resources.SELECT_JOIN;
						richTextBox1.Text += generateQuery(6);
						break;


					case 7:
						break;


					case 8:
						break;


					case 9:
						break;


					case 10:
						break;


					case 11:
						break;


					case 12:
						break;


					case 13:
						break;


					case 14:
						break;


					case 15:
						break;


					default:
						break;
				}
			}

		}
	}
}
