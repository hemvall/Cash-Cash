<template>
    <div v-if="interventionOpen" style="margin-top: 2%;margin-left: 5%;">
        <a>Label</a>
        <input v-model="label" class="inputForm" type="string" />
        <!-- <a>Lieu</a>
        <input v-model="lieu" class="inputForm" type="string" /> -->
        <a>Technicien</a>
        <select class="inputForm" v-model="NumEmploye">
            <option value="-1">---</option>
            <option v-for="t in techniciens" :key="t.id" :value="`${t.id}`">{{ t.nom }}</option>
        </select>
        <!-- <a>Client</a>
        <select class="inputForm">
            <option>Auchan</option>
        </select> -->
        <a>Date</a>
        <input class="inputForm" v-model="dateIntervention" type="date" />
        <button @click="updateIntervention()">Valider</button>
    </div>
    <div class="interventionContainer" v-for="i in interventions" :key="i.InterventionId">
        <div class="intervention">
            <div class="left contentBlock">
                <div style="display: flex; align-items: center; font-size: 15px;">
                    <h1>{{ i.commentaire }}</h1><a class="technicienLabel" v-for="tt in techFromIntervention(i.NumEmploye)">{{ tt.nom }}</a>
                </div>
                <p> {{ i.dateIntervention }} - 57 rue des peupliers - 15 km - Auchan</p>
            </div>
            <div class="right contentBlock df">
                <!-- <a class="roundButton df"><img src="../../assets/Icons/download.svg" /></a> -->
                <div
                    @click="interventionOpen = true; interventionOpenId = 1; label = i.commentaire; dateIntervention = i.dateIntervention">
                    <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            techniciens: [],
            interventions: [],
            interventionOpen: false,
            interventionOpenId: 0,
            NumEmploye: 1,
            label: '',
            dateIntervention: Date
        };
    },
    components: {},
    created() { this.fetchData() },
    methods: {
        fetchData() {
            this.techniciens = [];
            this.interventions = [];
            this.loading = true;

            fetch(`${this.$api}/Intervention`)
                .then(r => r.json())
                .then(json => {
                    this.interventions = json;
                    this.loading = false;
                    return;
                });
            fetch(`${this.$api}/Technicien`)
                .then(r => r.json())
                .then(json => {
                    this.techniciens = json;
                    this.loading = false;
                    return;
                });
        },
        interventionsFromTechnicien(iId) {
            return this.interventions.filter(p => p.NumEmploye == iId)
        },
        techFromIntervention(iId) {
            return this.techniciens.filter(p => p.NumEmploye == iId)
        },
        updateIntervention() {
            const requestOptions = {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({
                    NumIntervention: this.NumIntervention,
                    NumEmploye: this.NumEmploye,
                    contratId: this.NumContrat,
                    commentaire: this.label,
                    dateIntervention: this.dateIntervention
                })
            };
            fetch(`${this.$api}/Intervention/${this.interventionOpenId}`, requestOptions)
                .then(response => {
                    if (response.ok) { alert("L'intervention a bien été modifiée") }
                    else { alert("L'intervention n'a pas été modifiée") }
                    this.fetchData()
                })
                .then(location.reload())
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