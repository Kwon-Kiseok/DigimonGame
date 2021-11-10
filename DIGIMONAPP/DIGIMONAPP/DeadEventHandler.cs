//////////////////////////////////////////////////////////////////////////////////////////////////////
//
//파일명: DeadEventHandler.cs
//작성일: 2018.06.13
//작성자: 권기석
//내용  : 유닛 죽음 이벤트 구현부
//         
//        
//       
//
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIGIMON_DLL;

/// <summary>
/// 유닛이 죽었을 때의 이벤트 핸들러를 생성
/// 유닛의 체력과 생존여부를 받아온 후 
/// 체력이 0이하로 떨어질 경우 생존여부를 바꿔 주는 이벤트
/// </summary>
namespace DIGIMONAPP
{
    public delegate void DeadEventHandler(bool ALIVE);

    class DeadEventManager
    {
        public event DeadEventHandler DeadCall;

        public void DeadCheck(int hp, bool ALIVE)
        {
            if (hp > 0)
            {
                return;
            }
            else if (hp <= 0)
            {
                DeadCall(ALIVE = false);
            }
            
        }
    }
}