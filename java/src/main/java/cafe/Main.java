package cafe;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    static void main() {
        CafeConfig c = CafeConfig.getInstance();
        IO.println(c.getCafeName());
        CafeConfig c2 = CafeConfig.getInstance();
        IO.println(c2.getCafeName());
    }
}
