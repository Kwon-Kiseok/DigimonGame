//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: BattleManager.cs
//작성일: 2018.06.13
//작성자: 권기석
//내용  : 배틀시스템 구현 
//        공격방식 
//        
//       
//
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using DIGIMON_DLL;

namespace DIGIMONAPP
{
    public delegate void ATK_Attatch();    
    delegate int Battle_ATK();      //델리게이트 이용 


    /// <summary>
    /// 배틀 매치 시스템 컬렉션을 이용하여 두 개의 클래스를 
    /// 컬렉션 ArrayList callbacks 안에 담고 매칭 의도
    /// </summary>
    class Battle_Attatch  
    {
        private ArrayList callbacks = new ArrayList();
        public void Add(ATK_Attatch callback)
        {
            callbacks.Add(callback);
        }
        public void onBattle()
        {
            foreach(ATK_Attatch callback in callbacks)
            {
                callback();
            }
        }
    }
    class BattleManager
    {
        Battle_ATK PAtk, EAtk;

        /// <summary>
        ///일반 공격 구현 함수
        ///델리게이트 이용하여 체력 설정함수 HIT에-매개변수로 플레이어 공격력 설정하는 메서드 등록된 PAtk 전달
        ///마찬가지로 적 공격력 설정하는 메서드 EAtk를 통해 전투시 플레이어 체력 설정
        /// </summary>
        /// <param name="Player"></param>
        /// <param name="Enemy"></param>
        public void Do_Battle(Unit Player, Unit Enemy)
        {
            PAtk += new Battle_ATK(Player.DMG);
            EAtk += new Battle_ATK(Enemy.DMG);

            if (Enemy.HP() > 0 && Player.HP() > 0 && Enemy.Dead() != false)
            {
                Enemy.HIT(PAtk());
                Player.HIT(EAtk());
            }
            else if(Player.HP() < 0)
            {
                return;
            }
        }
        /// <summary>
        /// 스킬 공격 구현 함수
        /// 위와 동일한 구조에 추가 데미지 부분만 별도
        /// </summary>
        /// <param name="Player"></param>
        /// <param name="Enemy"></param>
        public void Do_Skill(Unit Player, Unit Enemy)
        {
            PAtk += new Battle_ATK(Player.DMG);
            EAtk += new Battle_ATK(Enemy.DMG);

            if (Enemy.HP() > 0 && Player.HP() > 0 && Enemy.Dead() != false)
            {
                Enemy.HIT(PAtk() + 20);  //추가 데미지는 20으로 설정
                Player.HIT(EAtk());
            }
            else if (Player.HP() < 0)
            {
                return;
            }
        }
    }
}
