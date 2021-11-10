//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: UnitFactory.cs
//작성일: 2018.06.10
//작성자: 권기석
//내용  : 유닛이 생성되는 팩토리 패턴 구현부 팩토리 패턴 사용
//        
//
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIGIMON_DLL;


namespace DIGIMONAPP
{
    /// <summary>
    /// 팩토리 패턴을 이용 UnitFactory 에서 각각의 유닛 타입팩토리 클래스 생성 (본 게임에서는 여러객체를 생성치 않지만 게임이 확장되어 여러객체를 생성할 경우 고려)
    /// 각 팩토리에서 GetUnit을 받아와 객체를 인스턴스해준다. 그 후 각 유닛클래스에 저장 된 객체의 멤버들을 Form1.cs에서 편하게 다루게 해준다.
    /// 유닛의 내용이 변경 될 점이 있으면 그 클래스 cs에서만 변경해주면 됨
    /// </summary>

    public abstract class UnitFactory
    {
        public virtual Unit GetUnit()
        {
            return new Unit();           
        }
    }

    /// <summary>
    /// 플레이어 유닛 부분
    /// </summary>
    public class CoromonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Coromon coromon = new Coromon();
            coromon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return coromon;
        }                  
    }
    public class AgumonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Agumon agumon = new Agumon();
            agumon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return agumon;
        }
    }
    public class GreymonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Greymon greymon = new Greymon();
            greymon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return greymon;
        }
    }

    public class TunomonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Tunomon tunomon = new Tunomon();
            tunomon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return tunomon;
        }
    }
    public class GabumonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Gabumon gabumon = new Gabumon();
            gabumon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return gabumon;
        }
    }
    public class GarurumonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Garurumon garurumon = new Garurumon();
            garurumon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return garurumon;
        }
    }

    public class OmegamonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Omegamon omegamon = new Omegamon();
            omegamon.GetUNITTYPE = UNITTYPE.PLAYER_CHAR;
            return omegamon;           
        }
    }



    /// <summary>
    /// 적 유닛 부분
    /// </summary>
    public class GekomonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Gekomon gekoomon = new Gekomon();
            gekoomon.GetUNITTYPE = UNITTYPE.ENEMY_CHAR;
            return gekoomon;
        }
    }
    public class EtemonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Etemon etemon = new Etemon();
            etemon.GetUNITTYPE = UNITTYPE.ENEMY_CHAR;
            return etemon;
        }
    }
    public class PinochimonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Pinochimon pinochimon = new Pinochimon();
            pinochimon.GetUNITTYPE = UNITTYPE.ENEMY_CHAR;
            return pinochimon;
        }
    }
    public class DiablomonFactory : UnitFactory
    {
        public override Unit GetUnit()
        {
            Diablomon diablomon = new Diablomon();
            diablomon.GetUNITTYPE = UNITTYPE.ENEMY_CHAR;
            return diablomon;
        }
    }
}
