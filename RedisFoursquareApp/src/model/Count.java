package model;
public class Count implements Comparable<Count> {
    public Long count;
    public String id;

    public Count(Long count, String id) {
        this.count = count;
        this.id = id;
    }

    @Override
    public int compareTo(Count o) {
        return Long.compare(count, o.count) < 0 ? 1 : Long.compare(count, o.count) > 0 ? -1 : 0;
        //return score < o.score ? -1 : score > o.score ? 1 : 0;
    }
}