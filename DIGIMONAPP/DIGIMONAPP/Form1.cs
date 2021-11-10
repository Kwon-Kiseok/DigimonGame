using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using DIGIMON_DLL;



namespace DIGIMONAPP
{
    public enum BaseDIGIMON { E_coromon, E_tunomon };

    public partial class DIGIMON : Form
    {
        /// <summary>
        /// 전역 멤버들 
        /// </summary>
        BattleManager battleManager = new BattleManager();
        Unit PlayerUnit;
        Unit EnemyUnit;
        BaseDIGIMON baseDIGIMON;
        int StageCount = 0;
        LEVEL value_LEVEL = LEVEL.BABY;
        bool Data_LVUP = false;
        bool EndingCondition = false;
        bool Ending = false;

        /// <summary>
        /// 쓰레드를 통하여 폭발 이미지 애니메이션
        /// 처리 하는 부분
        /// </summary>
        void Effect()
        {
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            Run();

            t1.Join();
        }
        void Run()
        {
            if (picture_Effect.Visible == false)
            {
                picture_Effect.Visible = true;
                picture_Effect.Image = DIGIMONAPP.Properties.Resources.이펙트;
            }
                Thread.Sleep(250);           //쓰레드 이용하여 공격누른 후 텀 구현 = 타격감처럼
        }

        /// <summary>
        /// 적 죽었을 때 이벤트 구현 부
        /// </summary>
        /// <param name="ALIVE"></param>
        static public void MyHandler(bool ALIVE)
        {
            ALIVE = false;
        }
        /// <summary>
        /// 이벤트 등록 부 , 죽었는지 체크 하는 부분
        /// </summary>
        /// <param name="unit"></param>
        public void DeadControll(Unit unit)
        {
            DeadEventManager deadEvent = new DeadEventManager();
            deadEvent.DeadCall += new DeadEventHandler(MyHandler);

            if(unit.Dead() != false)
            {
                deadEvent.DeadCheck(unit.HP(),unit.Dead());
            }
        }

        public DIGIMON()
        {
            InitializeComponent();
        }

        //게임 시작 버튼 클릭 시
        private void STARTBUTTON_Click(object sender, EventArgs e)
        {
            MAINLOGO.Visible = false;
            STARTBUTTON.Visible = false;
            Scene_panel1.Visible = true;
        }
        //게임 종료 버튼 클릭 시
        private void QUITBUTTON_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //코로몬 선택 시
        private void Select_coromon_Click(object sender, EventArgs e)
        {
            Scene_panel2.Visible = true;
            baseDIGIMON = BaseDIGIMON.E_coromon;
            Create_Player(baseDIGIMON);
            Create_Enemy();
            
        }
        //츠노몬 선택 시
        private void Select_tunomon_Click(object sender, EventArgs e)
        {
            Scene_panel2.Visible = true;
            baseDIGIMON = BaseDIGIMON.E_tunomon;
            Create_Player(baseDIGIMON);
            Create_Enemy();
        }
        

        /// <summary>
        /// 스킬 공격 버튼 함수 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SKILL_BUTTON_Click(object sender, EventArgs e)
        {
            if (Ending == true)
            {
                GameEnding();
            }
            Effect();
            battleManager.Do_Skill(PlayerUnit, EnemyUnit);
            Update_Unit_Data();

            if (EnemyUnit.Dead() == false)
            {
                StageCount++; Data_LVUP = true;
                MessageBox.Show("적 " + EnemyUnit.NAME() + "처치!!");
                picture_Effect.Visible = false;
                Create_Enemy();
            }
            if(PlayerUnit.Dead() == false && EndingCondition == false)
            {
                MessageBox.Show(PlayerUnit.NAME() + "사망!!" + "\n!!!게임종료!!!");
                Application.Exit();
            }
            else if(PlayerUnit.Dead() == false && EndingCondition == true)
            {
                MessageBox.Show(PlayerUnit.NAME() + "사망!!" + "\n!!!게임종료!!!");
                MessageBox.Show("어라??");
                MessageBox.Show("!!!FUSION 활성화!!!");

                LVup_BUTTON.Text = "FUSION";
            }
            
        }
        /// <summary>
        /// 일반 공격 버튼 클릭 시 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ATKBUTTON_Click(object sender, EventArgs e)
        {
            if (Ending == true)
            {
                GameEnding();
            }
            Effect();
            battleManager.Do_Battle(PlayerUnit, EnemyUnit);
            Update_Unit_Data();

            if(EnemyUnit.Dead() == false)
            {
                StageCount++; Data_LVUP = true;
                MessageBox.Show("적 " + EnemyUnit.NAME() + "처치!!");
                Create_Enemy();
                picture_Effect.Visible = false;
            }
            if (PlayerUnit.Dead() == false && EndingCondition == false)
            {
                MessageBox.Show(PlayerUnit.NAME() + "사망!!" + "\n!!!게임종료!!!");
                Application.Exit();
            }
            else if(PlayerUnit.Dead() == false && EndingCondition == true)
            {
                MessageBox.Show(PlayerUnit.NAME() + "사망!!" + "\n!!!게임종료!!!");
                MessageBox.Show("어라??");
                MessageBox.Show("!!!FUSION 활성화!!!");

                LVup_BUTTON.Text = "FUSION";
            }            
        }


        /// <summary>
        /// 유닛의 상세 정보 표출해주는 함수
        /// </summary>
        private void Update_Unit_Data()
        {
            label_PName.Text = "NAME: " + PlayerUnit.NAME();
            label_PHp.Text = "HP: " + PlayerUnit.HP();
            label_PDmg.Text = "DMG: " + PlayerUnit.DMG();
            label_PLevel.Text = "LEVEL: " + PlayerUnit.GETLEVEL();

            label_EName.Text = "NAME: " + EnemyUnit.NAME();
            label_EHp.Text = "HP: " + EnemyUnit.HP();
            label_EDmg.Text = "DMG: " + EnemyUnit.DMG();
            label_ELevel.Text = "LEVEL: " + EnemyUnit.GETLEVEL();
        }


        /// <summary>
        /// 레벨업 관련 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVup_BUTTON_Click(object sender, EventArgs e)
        {
            picture_Effect.Visible = false;
            if (Data_LVUP == false && EndingCondition == false)
            {
                MessageBox.Show("!!적을 처치해야 진화할 수 있습니다!!");
                return;
            }
            else if(Data_LVUP == false && EndingCondition == true)
            {
                return;
            }
            else if (Data_LVUP == true && EndingCondition == false)
            {
                MessageBox.Show("!!!" + PlayerUnit.NAME() + "진화!!!");
                value_LEVEL++;
                Create_Player(baseDIGIMON);
                MessageBox.Show("!!!" + PlayerUnit.NAME() + "!!!");
                Data_LVUP = false;
            }
            else if(PlayerUnit.Dead() == false && EndingCondition == true)
            {
                Create_Player(baseDIGIMON);
                MessageBox.Show("!!!" + PlayerUnit.NAME() + "!!!");
                Data_LVUP = false;
            }
        }

        /// <summary>
        /// 플레이어 생성 함수 
        /// </summary>
        /// <param name="baseDIGIMON"></param>
        public void Create_Player(BaseDIGIMON baseDIGIMON)
        {
           
            /////////////////시작 캐릭터가 코로몬 일 경우/////////////////////////
            if (baseDIGIMON == BaseDIGIMON.E_coromon && value_LEVEL == LEVEL.BABY)
            {
                //코로몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.코로몬;
                CoromonFactory coromonFactory = new CoromonFactory();
                Coromon coromon = (Coromon)coromonFactory.GetUnit();
                label_PName.Text = "NAME: " + coromon.NAME();
                label_PHp.Text = "HP: " + coromon.HP();
                label_PDmg.Text = "DMG: " + coromon.DMG();
                label_PLevel.Text = "LEVEL: " + coromon.GETLEVEL();

                PlayerUnit = coromon;
            }
            if(baseDIGIMON == BaseDIGIMON.E_coromon && value_LEVEL == LEVEL.ROOKIE)
            {
                //아구몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.아구몬;
                AgumonFactory agumonFactory = new AgumonFactory();
                Agumon agumon = (Agumon)agumonFactory.GetUnit();
                label_PName.Text = "NAME: " + agumon.NAME();
                label_PHp.Text = "HP: " + agumon.HP();
                label_PDmg.Text = "DMG: " + agumon.DMG();
                label_PLevel.Text = "LEVEL: " + agumon.GETLEVEL();

                PlayerUnit = agumon;
            }
            if (baseDIGIMON == BaseDIGIMON.E_coromon && value_LEVEL == LEVEL.CHAMPION)
            {
                //그레이몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.그레이몬;
                GreymonFactory greymonFactory = new GreymonFactory();
                Greymon greymon = (Greymon)greymonFactory.GetUnit();
                label_PName.Text = "NAME: " + greymon.NAME();
                label_PHp.Text = "HP: " + greymon.HP();
                label_PDmg.Text = "DMG: " + greymon.DMG();
                label_PLevel.Text = "LEVEL: " + greymon.GETLEVEL();

                PlayerUnit = greymon;
            }

            ////////////////////시작 캐릭터가 뿔몬 일 경우/////////////////////
            if (baseDIGIMON == BaseDIGIMON.E_tunomon && value_LEVEL == 0)
            {
                //뿔몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.뿔몬;
                TunomonFactory tunomonFactory = new TunomonFactory();
                Tunomon tunomon = (Tunomon)tunomonFactory.GetUnit();
                label_PName.Text = "NAME: " + tunomon.NAME();
                label_PHp.Text = "HP: " + tunomon.HP();
                label_PDmg.Text = "DMG: " + tunomon.DMG();
                label_PLevel.Text = "LEVEL: " + tunomon.GETLEVEL();

                PlayerUnit = tunomon;
            }
            if (baseDIGIMON == BaseDIGIMON.E_tunomon && value_LEVEL == LEVEL.ROOKIE)
            {
                //파피몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.파피몬;
                GabumonFactory gabumonFactory = new GabumonFactory();
                Gabumon gabumon = (Gabumon)gabumonFactory.GetUnit();
                label_PName.Text = "NAME: " + gabumon.NAME();
                label_PHp.Text = "HP: " + gabumon.HP();
                label_PDmg.Text = "DMG: " + gabumon.DMG();
                label_PLevel.Text = "LEVEL: " + gabumon.GETLEVEL();

                PlayerUnit = gabumon;
            }
            if (baseDIGIMON == BaseDIGIMON.E_tunomon && value_LEVEL == LEVEL.CHAMPION)
            {
                //가루몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.가루몬;
                GarurumonFactory garurumonFactory = new GarurumonFactory();
                Garurumon garurumon = (Garurumon)garurumonFactory.GetUnit();
                label_PName.Text = "NAME: " + garurumon.NAME();
                label_PHp.Text = "HP: " + garurumon.HP();
                label_PDmg.Text = "DMG: " + garurumon.DMG();
                label_PLevel.Text = "LEVEL: " + garurumon.GETLEVEL();

                PlayerUnit = garurumon;
            }

            if(EndingCondition == true)
            {
                //오메가몬 정보 구현
                picture_PLAYER.Image = DIGIMONAPP.Properties.Resources.오메가몬;
                OmegamonFactory omegamonFactory = new OmegamonFactory();
                Omegamon omegamon = (Omegamon)omegamonFactory.GetUnit();
                label_PName.Text = "NAME: " + omegamon.NAME();
                label_PHp.Text = "HP: " + omegamon.HP();
                label_PDmg.Text = "DMG: " + omegamon.DMG();
                label_PLevel.Text = "LEVEL: " + omegamon.GETLEVEL();

                PlayerUnit = omegamon;
                Ending = true;
            }
        }

        /// <summary>
        /// 적 생성 함수 부분
        /// </summary>
        public void Create_Enemy()
        {
            //첫 스테이지 개굴몬
            if (StageCount == 0)
            {
                picture_ENEMY.Image = DIGIMONAPP.Properties.Resources.개굴몬;
                GekomonFactory gekomonFactory = new GekomonFactory();
                Gekomon gekomon = (Gekomon)gekomonFactory.GetUnit();
                label_EName.Text = "NAME: " + gekomon.NAME();
                label_EHp.Text = "HP: " + gekomon.HP();
                label_EDmg.Text = "DMG: " + gekomon.DMG();
                label_ELevel.Text = "LEVEL: " + gekomon.GETLEVEL();

                EnemyUnit = gekomon;
            }
            //두번째 스테이지 에테몬
            else if(StageCount == 1)
            {
                picture_ENEMY.Image = DIGIMONAPP.Properties.Resources.에테몬;
                EtemonFactory etemonFactory = new EtemonFactory();
                Etemon etemon = (Etemon)etemonFactory.GetUnit();
                label_EName.Text = "NAME: " + etemon.NAME();
                label_EHp.Text = "HP: " + etemon.HP();
                label_EDmg.Text = "DMG: " + etemon.DMG();
                label_ELevel.Text = "LEVEL: " + etemon.GETLEVEL();

                EnemyUnit = etemon;
            }
            //세번째 스테이지 피노키몬
            else if(StageCount == 2)
            {
                picture_ENEMY.Image = DIGIMONAPP.Properties.Resources.피노키몬;
                PinochimonFactory pinochimonFactory = new PinochimonFactory();
                Pinochimon pinochimon = (Pinochimon)pinochimonFactory.GetUnit();
                label_EName.Text = "NAME: " + pinochimon.NAME();
                label_EHp.Text = "HP: " + pinochimon.HP();
                label_EDmg.Text = "DMG: " + pinochimon.DMG();
                label_ELevel.Text = "LEVEL: " + pinochimon.GETLEVEL();

                EnemyUnit = pinochimon;
            }
            //마지막 스테이지 디아블로몬
            else if(StageCount == 3)
            {
                picture_ENEMY.Image = DIGIMONAPP.Properties.Resources.디아블로몬;
                DiablomonFactory diablomonFactory = new DiablomonFactory();
                Diablomon diablomon = (Diablomon)diablomonFactory.GetUnit();
                label_EName.Text = "NAME: " + diablomon.NAME();
                label_EHp.Text = "HP: " + diablomon.HP();
                label_EDmg.Text = "DMG: " + diablomon.DMG();
                label_ELevel.Text = "LEVEL: " + diablomon.GETLEVEL();

                EnemyUnit = diablomon;
                EndingCondition = true;
            }

            MessageBox.Show("적 " + EnemyUnit.NAME() + "출현!!");
        }

        /// <summary>
        /// 게임 엔딩 부
        /// </summary>
        public void GameEnding()
        {
            picture_Ending.Visible = true;
            picture_Ending.Image = DIGIMONAPP.Properties.Resources.디아블로몬뚝배기;
            MessageBox.Show("!!!디아블로몬 처치!!!");
            MessageBox.Show("!!!게임 종료!!!");
            Application.Exit();
        }

        private void UnitLibrary_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            FileStream fs;
            StreamReader xmlStream;

            fs = new FileStream("../../UnitXML.xml", FileMode.Open, FileAccess.Read);
            xmlStream = new StreamReader(fs);

            ds.ReadXml(xmlStream);
            fs.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
