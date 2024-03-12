package com.sgic.ppms.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "birth_history")
public class BirthHistory {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn (name = "childId")
    private ChildDetail childDetail;

    private String antenatalHistory;
    private String modeOfDelivery;
    private int gestationalAge;
    private double birthWeight;
    private String postnatalHistory;


    public String getAntenatalHistory() {
        return antenatalHistory;
    }

    public void setAntenatalHistory(String antenatalHistory) {
        this.antenatalHistory = antenatalHistory;
    }

    public String getModeOfDelivery() {
        return modeOfDelivery;
    }

    public void setModeOfDelivery(String modeOfDelivery) {
        this.modeOfDelivery = modeOfDelivery;
    }

    public int getGestationalAge() {
        return gestationalAge;
    }

    public void setGestationalAge(int gestationalAge) {
        this.gestationalAge = gestationalAge;
    }

    public String getPostnatalHistory() {
        return postnatalHistory;
    }

    public void setPostnatalHistory(String postnatalHistory) {
        this.postnatalHistory = postnatalHistory;
    }

    public double getBirthWeight() {
        return birthWeight;
    }

    public void setBirthWeight(double birthWeight) {
        this.birthWeight = birthWeight;
    }
}