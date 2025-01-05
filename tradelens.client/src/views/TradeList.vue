
<script lang="ts">
    import { getTrades } from '@/api/tradeLensApi';
   import { defineComponent } from 'vue';

   type Forecasts = {
       date: string,
       temperatureC: string,
       temperatureF: string,
       summary: string
   }[];

   interface Data {
       loading: boolean,
       post: null | Forecasts
   }

   export default defineComponent({
       data(): Data {
           return {
               loading: false,
               post: null
           };
       },
       created() {
           // fetch the data when the view is created and the data is
           // already being observed
           this.fetchData();
       },
       watch: {
           // call again the method if the route changes
           '$route': 'fetchData'
       },
       methods: {
           fetchData(): void {
               this.post = null;
               this.loading = true;

               getTrades()
                   .then(r => {
                    console.log(r)
                   })
           }
       },
   });
</script>

<template>
   <div class="trade-list">
       <h1 class="trade-list__title">Trade journal</h1>
   </div>
</template>
