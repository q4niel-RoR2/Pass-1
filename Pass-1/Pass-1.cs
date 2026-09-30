using BepInEx;

namespace Pass_1 {
    [BepInPlugin("q4niel.pass1", "Pass 1", "0.0.0")]
    public class Pass1 : BaseUnityPlugin {
        public void Awake()
            => Logger.LogInfo("Pass 1 Init");
    }
}