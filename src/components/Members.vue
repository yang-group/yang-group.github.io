<template>
    <div class="lighten-2">
      <v-container>
        <template v-for="(value,key,index) in std_cat" >
          <v-row :key="index">
            <v-col
              :key="index"
              class="mt-2"
              cols="12"
              v-show="value.length != 0"
            >
              <h2>{{ key }}</h2>
            </v-col>
          </v-row>
          <v-row :key="index">
            <v-col
              v-for="(stu,idx) in value"
              :key="`${key}${idx}`"
              cols="3"
            >
              <v-sheet>
                <Student :stu="stu" />
              </v-sheet>
            </v-col>
          </v-row>
        </template>
      </v-container>
    </div>
</template>

<script>
import Student from '@/components/Student'

export default {
  props: ['memberData'],
  components: {
    Student
  },
  data: () => ({
    std_cat: {}
  }),
  mounted () {
    this.std_cat = this.memberData
  }
}
</script>

<style>

</style>
