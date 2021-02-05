using UnityEngine;
using System.Collections;

public class UrgDevice : MonoBehaviour {

	public enum CMD
	{
		VV, PP, II, //傳感器信息請求命令（3種） 
		BM, QT, //測量開始/結束命令
		MD, GD, // 距離請求命令（2種）
		ME //距離/受光強度要求指令
	}

	public static string GetCMDString(CMD cmd)
	{
		return cmd.ToString();
	}
}
