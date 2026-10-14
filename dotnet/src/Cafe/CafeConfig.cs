using System;

namespace Cafe;

public class CafeConfig
{
    private const string NAME = "cafe";
    private static CafeConfig _instance;
    private CafeConfig() {}
    public static CafeConfig GetInstance() {
        if(_instance != null)
            return _instance;
        else{
            _instance = new CafeConfig();
            return _instance;
        }
    }

    public String getCafeName() {
        return NAME;
    }
}
