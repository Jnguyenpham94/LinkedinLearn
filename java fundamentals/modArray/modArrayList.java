package modArray;

import java.util.ArrayList;

public class modArrayList<D> extends ArrayList<D> {

    public D getModArrayList(int index) {
        int validIndex = Math.abs(index) % this.size();
        return this.get(validIndex);
    }
}
