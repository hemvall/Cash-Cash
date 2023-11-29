<template>
    <div class="">
        <Header></Header>
    </div>
</template>

<script>
import Header from '../../components/Header/HeaderPage.vue'

import { defineComponent } from 'vue';

export default defineComponent({
    created() {
        this.fetchData();
    },
    data() {
        return {
            user: {}
        };
    },
    components: { Header },
    methods: {
        fetchData() {
            this.user = {};
            this.loading = true;

            fetch(`${this.$api}/users/${localStorage.getItem('userId')}`)
                .then(r => r.json())
                .then(json => {
                    this.user = json;
                    this.loading = false;
                    return;
                });
        }
    },
});
</script>

<style scoped></style>