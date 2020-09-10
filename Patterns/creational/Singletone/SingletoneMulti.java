//Многопоточный Одиночка 

public final class Singleton {
    // Поле обязательно должно быть объявлено volatile, чтобы двойная проверка блокировки сработала как надо.
    private static volatile Singleton instance;

    public String value;

    private Singleton(String value) {
        this.value = value;
    }

    public static Singleton getInstance(String value) {
        // Используется «блокировка с двойной проверкой» (Double-Checked Locking).
        // Её смысл - предотвратить создание нескольких объектов-одиночек, если метод
        // будет вызван из нескольких потоков одновременно.

        Singleton result = instance;
        if (result != null) {
            return result;
        }
        synchronized(Singleton.class) {
            if (instance == null) {
                instance = new Singleton(value);
            }
            return instance;
        }
    }

    public static void main(String[] args) {
    }
}