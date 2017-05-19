package model;
public class Dist implements Comparable<Dist> {
	public Double dist;
    public String id;

    public Dist(Double dist, String id) {
        this.dist = dist;
        this.id = id;
    }

    @Override
    public int compareTo(Dist o) {
        return Double.compare(dist, o.dist) > 0 ? 1 : Double.compare(dist, o.dist) < 0 ? -1 : 0;
        //return score < o.score ? -1 : score > o.score ? 1 : 0;
    }
}