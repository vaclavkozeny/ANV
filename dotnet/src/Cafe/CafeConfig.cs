using System;

namespace Cafe;

public class CafeConfig
{
    private string NAME = "cafe";
    private static CafeConfig instance;
    private CafeConfig() {}
    public static CafeConfig getInstance() {
        if(instance != null)
            return instance;
        else{
            instance = new CafeConfig();
            return instance;
        }
    }

    public String getCafeName() {
        return NAME;
    }
}
