<template>  
  <div>
    <div v-if="this.$store.state.userConnecte">
      <router-view/>
    </div>
    <div v-else>
      <ConnectionPage></ConnectionPage>
    </div>
  </div>
</template>

<script>
import { defineComponent } from 'vue';
import ConnectionPage from './components/Connection/ConnectionPage.vue';
export default defineComponent({

    data() {
        return {

        };
    },
    components: {ConnectionPage},
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
        },
        ContratsFromTechnicien(iId) {
            return this.Contrats.filter(p => p.techId == iId)
        }
    }
});
</script>

<style>
/* theme $
// mainColor : #103941
// smokeGrey : #D9D9D9
// lightGrey : #EFF0F1
*/
@import url('./assets/scss/_main.scss');

* {
  font-family: 'Source Code Pro';
}
</style>

