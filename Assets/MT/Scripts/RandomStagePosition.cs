using System.Collections.Generic;
using UnityEngine;

public class RandomStagePosition : MonoBehaviour
{
// 各Stageを格納するリスト
    public List<GameObject> StageList;

    // 各Stageを配置する場所
    public Transform spawnPoint_Left;
    public Transform spawnPoint_Center;
    public Transform spawnPoint_Right;

    void Start()
    {
        SpawnRandomStage();
    }

    void SpawnRandomStage()
    {
        // 各リストからランダムにPrefabを抽選
        GameObject selectedStage_Left = StageList[Random.Range(0, StageList.Count)];
        GameObject selectedStage_Center = StageList[Random.Range(0, StageList.Count)];
        GameObject selectedStage_Right = StageList[Random.Range(0, StageList.Count)];

        // 抽選されたPrefabをそれぞれの位置にインスタンス化
        Instantiate(selectedStage_Left, spawnPoint_Left.position, Quaternion.identity,spawnPoint_Left);
        Instantiate(selectedStage_Center, spawnPoint_Center.position, Quaternion.identity,spawnPoint_Center);
        Instantiate(selectedStage_Right, spawnPoint_Right.position, Quaternion.identity,spawnPoint_Right);
    }
}