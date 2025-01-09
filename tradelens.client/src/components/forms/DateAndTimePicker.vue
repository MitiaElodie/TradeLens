<script lang="ts">
import VueDatePicker from '@/plugins/vueDatePicker.ts'

export default {
   name: 'DateAndTimePicker',
   components: {
      VueDatePicker,
   },
   props: {
      modelValue: {
         type: String,
         default: '',
      },

      label: {
         type: String,
         default: '',
      },
   },

   emits: ['update:modelValue'],

   data() {
      return {
         date: '',
      }
   },

   created() {
      this.date = this.modelValue
   },

   methods: {
      updateDate(date: string) {
         this.date = date
         this.$emit('update:modelValue', date)
      },
   },
}
</script>
<template>
   <div class="date-and-time-picker">
      <label class="date-and-time-picker__label">{{ label }}</label>
      <VueDatePicker
         v-model="date"
         :label="label"
         time-picker-inline
         @update:modelValue="updateDate"
      />
   </div>
</template>