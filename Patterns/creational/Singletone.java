package creational.singletone;

/**
 * Одиночка:
 * цель: обеспечить чтобы в программе у нас был только один экземпляр какого-то класса
 */
public final class Singleton {
    private static Singleton instance;
    public String value;

    private Singleton(String value) {
        // Этот код эмулирует медленную инициализацию.
        try {
            Thread.sleep(1000);
        } catch (InterruptedException ex) {
            ex.printStackTrace();
        }
        this.value = value;
    }

    public static Singleton getInstance(String value) {
        if (instance == null)   {
            instance = new Singleton(value);
        }
        return instance;
    }
}