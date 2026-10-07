package cafe;

public class CafeConfig {
    private final String NAME = "cafe";
    private static CafeConfig instance;
    //private String cafeName;
    private CafeConfig(){};

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
