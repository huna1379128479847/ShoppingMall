using System.IO; // ファイル操作用
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private string saveFilePath;

    private void Start()
    {
        // 保存ファイルのパスを設定
        saveFilePath = Path.Combine(Application.persistentDataPath, "SaveData.json");

        // データを読み込む
        LoadData();
    }

    // データを保存
    public void SaveData()
    {
        SaveData saveData = new SaveData
        {
            HaveKey = InformationManager.HaveKey,
            HaveCamera = InformationManager.HaveCamera,
            HaveAlarm_clock = InformationManager.HaveAlarm_clock,
            HaveWatch = InformationManager.HaveWatch,
            HaveBall = InformationManager.HaveBall,
            HaveLoudspeaker = InformationManager.HaveLoudspeaker,
            HaveSalt = InformationManager.HaveSalt,
            HaveCushion_that_ruins_people = InformationManager.HaveCushion_that_ruins_people,
            HaveMetal_bat = InformationManager.HaveMetal_bat,
            HaveRobot_Parts = InformationManager.HaveRobot_Parts,
            HaveSetting_materials_collection = InformationManager.HaveSetting_materials_collection,
            HaveSweets = InformationManager.HaveSweets,

            Lock_END_0 = InformationManager.Lock_END_0,
            Lock_END_1 = InformationManager.Lock_END_1,
            Lock_END_2 = InformationManager.Lock_END_2,
            Lock_END_3 = InformationManager.Lock_END_3,
            Lock_END_4 = InformationManager.Lock_END_4,
            Lock_GAMEOVER = InformationManager.Lock_GAMEOVER
        };

        // JSON に変換
        string json = JsonUtility.ToJson(saveData, true);

        // ファイルに書き込み
        File.WriteAllText(saveFilePath, json);

        Debug.Log("データを保存しました: " + saveFilePath);
    }

    // データを読み込む
    public void LoadData()
    {
        if (File.Exists(saveFilePath))
        {
            // ファイルから JSON を読み込み
            string json = File.ReadAllText(saveFilePath);

            // JSON をオブジェクトに変換
            SaveData loadedData = JsonUtility.FromJson<SaveData>(json);

            // 値を復元
            InformationManager.HaveKey = loadedData.HaveKey;
            InformationManager.HaveCamera = loadedData.HaveCamera;
            InformationManager.HaveAlarm_clock = loadedData.HaveAlarm_clock;
            InformationManager.HaveWatch = loadedData.HaveWatch;
            InformationManager.HaveBall = loadedData.HaveBall;
            InformationManager.HaveLoudspeaker = loadedData.HaveLoudspeaker;
            InformationManager.HaveSalt = loadedData.HaveSalt;
            InformationManager.HaveCushion_that_ruins_people = loadedData.HaveCushion_that_ruins_people;
            InformationManager.HaveMetal_bat = loadedData.HaveMetal_bat;
            InformationManager.HaveRobot_Parts = loadedData.HaveRobot_Parts;
            InformationManager.HaveSetting_materials_collection = loadedData.HaveSetting_materials_collection;
            InformationManager.HaveSweets = loadedData.HaveSweets;

            InformationManager.Lock_END_0 = loadedData.Lock_END_0;
            InformationManager.Lock_END_1 = loadedData.Lock_END_1;
            InformationManager.Lock_END_2 = loadedData.Lock_END_2;
            InformationManager.Lock_END_3 = loadedData.Lock_END_3;
            InformationManager.Lock_END_4 = loadedData.Lock_END_4;
            InformationManager.Lock_GAMEOVER = loadedData.Lock_GAMEOVER;

            Debug.Log("データを読み込みました: " + saveFilePath);
        }
        else
        {
            Debug.LogWarning("保存ファイルが見つかりません: " + saveFilePath);
            // 保存ファイルがない場合は、初期化処理を行うか、保存を呼び出す
            InitializeData();
        }
    }

    // 初期データを設定する
    private void InitializeData()
    {
        // 初期化処理、例えばデフォルトの値を設定
        InformationManager.HaveKey = false;
        InformationManager.HaveCamera = false;
        InformationManager.HaveAlarm_clock = false;
        InformationManager.HaveWatch = false;
        InformationManager.HaveBall = false;
        InformationManager.HaveLoudspeaker = false;
        InformationManager.HaveSalt = false;
        InformationManager.HaveCushion_that_ruins_people = false;
        InformationManager.HaveMetal_bat = false;
        InformationManager.HaveRobot_Parts = false;
        InformationManager.HaveSetting_materials_collection = false;
        InformationManager.HaveSweets = false;

        InformationManager.Lock_END_0 = false;
        InformationManager.Lock_END_1 = false;
        InformationManager.Lock_END_2 = false;
        InformationManager.Lock_END_3 = false;
        InformationManager.Lock_END_4 = false;
        InformationManager.Lock_GAMEOVER = false;

        Debug.Log("初期化データを設定しました。");

        // 初期化後にデータを保存
        SaveData();
    }
}
