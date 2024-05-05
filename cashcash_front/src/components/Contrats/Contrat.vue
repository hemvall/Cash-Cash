<template>
    <div class="ContratContainer" v-for="i in Contrats" :key="i.id">
        <div v-if="hidden == true">
            <div id="app" ref="document">
                <div style="margin: 0 5%;" id="element-to-convert">
                    <h1>Cash Cash</h1>
                    <p>Entre Cash Cash et Auchan Leers, il est convenu ce qui suit : <br><br>

                        Article 1 : Objet du contrat<br>

                        Cash Cash s'engage à fournir des services de caisse enregistreuse au magasin ______, pendant la
                        période allant du {{ i.dateSignature }} au {{ i.dateecheance }}.<br><br>

                        Article 2 : Numéro de contrat<br>

                        Le présent contrat est identifié par le numéro {{ i.numContrat }}.<br><br>

                        Article 3 : Date de signature<br>

                        Le contrat a été signé le {{ i.dateSignature }}.<br><br>

                        Article 4 : Durée du contrat<br>

                        Ce contrat entre en vigueur à la date de signature et prend fin le {{ i.dateecheance }}.<br><br>

                        Article 5 : Engagement des parties

                        Cash Cash s'engage à fournir des services de caisse enregistreuse conformes aux normes
                        convenues,
                        tandis qu'Auchan Leers s'engage à payer les frais de service convenus selon les termes de
                        paiement
                        définis.<br><br>

                        Article 6 : Numéro client<br>

                        Fait en double exemplaire, en date du {{ i.dateSignature }}.<br><br>

                        Pour Cash Cash: [Signature]<br>

                        Pour _____ : [Signature]

                    </p>
                </div>
            </div>
        </div>
        <div class="Contrat">
            <div class="left contentBlock">
                <div style="display: flex; align-items: center; font-size: 15px;">
                    <h1>Contrat n°{{ i.numContrat }} </h1><a class="technicienLabel"> - NumClient {{ i.clientId }}</a>
                </div>
                <p> dateSignature {{ i.dateSignature }} </p>
                <p> dateecheance {{ i.dateecheance }} </p>
            </div>
            <div class="right contentBlock df">
                <a class="roundButton df" @click="exportToPDF()"><img src="../../assets/Icons/download.svg" /></a>
                <div @click="ContratOpen = !ContratOpen">
                    <a class="roundButton df"><img src="../../assets/Icons/edit.svg" /></a>
                </div>
            </div>
        </div>
        <div v-if="ContratOpen" style="margin-top: 2%;">
            <a>Date signature</a>
            <input class="inputForm" v-model="dateSignature" type="date" value="`{{ i.dateSignature }}`" />
            <a>Date échéance</a>
            <input class="inputForm" type="date" />
            <a>Technicien</a>
            <select class="inputForm">
                <option v-for="t in techniciens" :key="t.numEmploye">{{ t.numEmploye }}</option>
            </select>
            <a>Client</a>
            <select class="inputForm">
                <option v-for="c in clients" :key="c.NumClient">{{ c.NumClient }}</option>
            </select>
            <a>Date</a>
            <input class="inputForm" type="date" />
        </div>
    </div>
</template>

<script>
import { defineComponent } from 'vue';
import html2pdf from "html2pdf.js";

export default defineComponent({

    data() {
        return {
            Contrats: [],
            clients: [],
            techniciens: [],
            ContratOpen: false,
            dateSignature: '',
            hidden: true
        };
    },
    components: {},
    created() { this.fetchData() },
    methods: {
        fetchData() {
            this.Contrats = [];
            this.loading = true;

            fetch(`${this.$api}/Contrat`)
                .then(r => r.json())
                .then(json => {
                    this.Contrats = json;
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
            fetch(`${this.$api}/Client`)
                .then(r => r.json())
                .then(json => {
                    this.clients = json;
                    this.loading = false;
                    return;
                });
        },
        exportToPDF() {
            html2pdf(document.getElementById('element-to-convert'));
        },
        ContratsFromTechnicien(iId) {
            return this.Contrats.filter(p => p.techId == iId)
        }
    }
});
</script>

<style scoped>
.ContratContainer {
    margin-left: 5%;
    margin-top: 2%;

}

.Contrat {
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