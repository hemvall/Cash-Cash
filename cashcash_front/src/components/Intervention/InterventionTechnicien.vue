<template>
    <div style="display: flex; margin-left: 5%;">
        <div v-if="formOpen">
            <a>Commentaire {{ selectedIntervention }}</a>
            <input v-model="commentaire" type="text">
        </div>
        <div v-if="formOpen">
            <a>Temps</a>
            <input v-model="time" type="time" step="300">
        </div>
        <div v-if="formOpen">
            <button @click="updateIntervention()">Valider</button>
        </div>
    </div>
    <div class="interventionContainer" v-for="i in interventionsFromTechnicien(1)" :key="i.interventionId">
        <div class="intervention">
            <div class="left contentBlock">
                <h1>{{ i.commentaire }}</h1>
                <p>{{ i.dateIntervention }}</p>
                <!-- 57 rue des peupliers - 15 km - Auchan -->
            </div>
            <div class="right contentBlock df">
                <!-- <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a> -->
                <a class="roundButton df" @click="formOpen = true; selectedIntervention = i.interventionId;"><img
                        src="../../assets/Icons/check-solid.svg" /></a>
                <!-- <a class="roundButton df" @click="timeOpen = !timeOpen; commentOpen = false;"><img
                        src="../../assets/Icons/hourglass.svg" /></a> -->
            </div>
        </div>

    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            interventions: [],
            formOpen: false,
            selectedIntervention: 0,
            time: '',
            commentaire:''
        };
    },
    components: {},
    created() { this.fetchData() },
    methods: {
        fetchData() {
            this.interventions = [];
            this.loading = true;

            fetch(`${this.$api}/Intervention`)
                .then(r => r.json())
                .then(json => {
                    this.interventions = json;
                    this.loading = false;
                    return;
                });
        },
        interventionsFromTechnicien(iId) {
            return this.interventions.filter(p => p.techId == iId)
        },
        updateIntervention() {
            const requestOptions = {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({
                    interventionId: this.selectedIntervention,
                    techId: this.techId,
                    etat: "Terminé",
                    commentaire: this.label,
                    dateIntervention: this.dateIntervention
                })
            };
            fetch(`${this.$api}/Intervention/${this.selectedIntervention}`, requestOptions)
                .then(response => {
                    if (response.ok) { alert("L'intervention a bien été modifiée") }
                    else { alert("L'intervention n'a pas été modifiée") }
                    this.fetchData()
                })
        }
    }
});
</script>

<style scoped>
.interventionContainer {
    margin-left: 3%;
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
    font-size: 20px;
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

img {
    width: 45px;
}
</style>