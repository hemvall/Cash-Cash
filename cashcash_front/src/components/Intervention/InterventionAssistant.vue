<template>
    <div class="interventionContainer" v-for="i in interventions" :key="i.id">
        <div class="intervention">
            <div class="left contentBlock">
                <div style="display: flex; align-items: center; font-size: 15px;">
                    <h1>{{i.commentaire}}</h1><a class="technicienLabel">Antoine BLANQUAERT</a>
                </div>
                <p>57 rue des peupliers - 15 km - {{ i.dateIntervention }} - Auchan</p>
            </div>
            <div class="right contentBlock df">
                <a class="roundButton df"><img src="../../assets/Icons/download.svg" /></a>
                <div @click="interventionOpen = !interventionOpen">
                    <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a>
                </div>
            </div>
        </div>
        <div v-if="interventionOpen" style="margin-top: 2%;">
            <a>Label</a>
            <input class="inputForm" type="string" />
            <a>Lieu</a>
            <input class="inputForm" type="string" />
            <a>Technicien</a>
            <select class="inputForm">
                <option>Antoine</option>
            </select>
            <a>Client</a>
            <select class="inputForm">
                <option>Auchan</option>
            </select>
            <a>Date</a>
            <input class="inputForm" type="date" />
        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({

    data() {
        return {
            interventions: [],
            interventionOpen: false,
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