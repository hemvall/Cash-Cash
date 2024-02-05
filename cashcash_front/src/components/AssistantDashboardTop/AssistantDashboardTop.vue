<template>
    <div class="dashboardTop">

        <h2 class="title"> <img height="50px" style="margin-right: 1%;" src="../../assets/Icons/wave-hand.png" /><strong>Bonjour Louis, </strong></h2>
        <div class="layer">
            <div class="block">
                <div class="left contentBlock"><img height="125px" src="../../assets/Icons/technicien.png" /></div>
                <div class="right contentBlock">
                    <div>
                        <h2>Techniciens</h2>
                        <h1>24</h1>
                    </div>
                </div>
            </div>
            <div class="block">
                <div class="left contentBlock"><img height="125px" src="../../assets/Icons/assistant.webp" /></div>
                <div class="right contentBlock">
                    <div>
                        <h2>Assistants</h2>
                        <h1>37</h1>
                    </div>
                </div>
            </div>
            <div class="block">
                <div class="left contentBlock"><img height="125px" src="../../assets/Icons/contrat.png" /></div>
                <div class="right contentBlock">
                    <div>
                        <h2>Contrats</h2>
                        <h1>4</h1>
                    </div>
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
        };
    },
    components: {},
    created() { this.fetchData() },
    methods: {
        fetchData() {
            this.techniciens = [];
            this.loading = true;

            fetch(`${this.$api}/Technicien`)
                .then(r => r.json())
                .then(json => {
                    this.techniciens = json;
                    this.loading = false;
                    return;
                });

        },
        interventionsFromTechnicien(iId) {
            return this.interventions.filter(p => p.techId == iId)
        },
    }
});
</script>

<style scoped>
.dashboardTop {
    box-sizing: border-box;
    margin: 0;
    padding: 2% 0 3% 0;
    background-color: #d9d9d9;
}

.title {
    font-size: 28px;
    font-weight: bold;
    margin-left: 5%;
    color: #103941;
    display: flex;
    align-items: center;
    font-family: helvetica !important;
}

.layer {
    display: flex;
    justify-content: space-around;
}

.block {
    width: 28%;
    display: flex;
    border-radius: 15px;
    padding: 1%;
    background-color: #EFF0F1;
}

.left,
.right {
    flex: 1;
}

.left {
    flex: 20;
}

.right {
    flex: 80;
}

.contentBlock {
    display: flex;
    justify-content: center;
    vertical-align: middle;
    align-items: center;
    text-align: center;
    color: #103941;
    font-size: 17px;
}

h1 {
    font-size: 54px;
}


</style>