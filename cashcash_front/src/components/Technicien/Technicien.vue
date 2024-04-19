<template>
    <div class="interventionContainer" v-for="t in techniciens" :key="t.id">
        <div class="intervention">
            <div class="left contentBlock">
                <div style="display: flex; align-items: center; font-size: 18px;">
                    <h1 v-for="e in nameFromTech(t.numEmploye)" :key="e.nom">{{ e.nom }}</h1>
                    <p style="font-size: 22px; margin-left: 2%;">- {{ t.qualification }}</p><a class="technicienLabel"
                        v-for="a in agencesFromTech(t.numEmploye)" :key="a.numAgence">{{ a.nomAgence }}</a>
                </div>
            </div>
            <div class="right contentBlock df">
                <div @click="EditOpen = !EditOpen">
                    <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a>
                </div>
            </div>
        </div>
        <div v-if="EditOpen" style="margin-top: 2%;">
            <a>Prénom</a>
            <input class="inputForm" type="string" />
            <a>Nom</a>
            <input class="inputForm" type="string" />

        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            EditOpen: false,
            techniciens: [],
            agences: [],
            employes: [],
        };
    },
    components: {},
    created() { this.fetchData() },
    methods: {
        fetchData() {
            this.techniciens = [];
            this.agences = [];
            this.loading = true;

            fetch(`${this.$api}/Technicien`)
                .then(r => r.json())
                .then(json => {
                    this.techniciens = json;
                    console.log(this.techniciens);
                    this.loading = false;
                    return;
                });
            fetch(`${this.$api}/Agence`)

                .then(r => r.json())
                .then(json => {
                    this.agences = json;
                    console.log(this.agences);
                    this.loading = false;
                    return;
                });
            fetch(`${this.$api}/Employe`)

                .then(r => r.json())
                .then(json => {
                    this.employes = json;
                    console.log(this.employes);
                    this.loading = false;
                    return;
                });

        },

        agencesFromTech(aId) {
            let i = this.agences.filter(p => p.numAgence == aId);
            console.log("bbbbb" + i);
            return i;
        },
        nameFromTech(tId){
            let i = this.employes.filter(p => p.numEmploye == tId);
            console.log("employes"+i);
            return i;
        }

    }
});
</script>

<style scoped>
.interventionContainer {
    margin-left: 5%;
    margin-top: 2%;

}

.intervention {
    background-color: #d9d9d9;
    width: 80%;
    padding: 1% 3%;
    border-radius: 25px;
    display: flex;
}

.left,
.right {
    flex: 1;
}

.left {
    flex: 70;
}

.right {
    flex: 30;
}

.contentBlock {
    justify-content: flex-end;
}

.df {
    display: flex;
    align-items: center;
}

.roundButton {
    cursor: pointer;
    border-radius: 50%;
    height: 5vw;
    width: 5vw;
    margin-right: 2%;
    background-color: #103941;
    justify-content: center;
    transition: .3s ease-in-out;
}

.roundButton:hover {
    background-color: #191E26;
}

.technicienLabel {
    background-color: #103941;
    color: white;
    padding: 1% 3%;
    border-radius: 15px;
    margin-left: 2%;
}

img {
    width: 30px;
}

.inputForm {
    margin-right: 2%;
}
</style>