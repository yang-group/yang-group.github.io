<template>
    <div class="lighten-2">
      <v-container>
        <template v-for="(value,key,index) in std_cat" >
          <div :key="index" v-if="cards.includes(key)">
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
              <!-- {{key}} -->
                <v-col
                  v-for="(stu,idx) in value"
                  :key="`${key}${idx}`"
                  cols="2"
                >
                  <v-sheet>
                    <Student :stu="stu" />
                  </v-sheet>
                </v-col>
            </v-row>
          </div>
          <div class="mt-5" :key="index" v-if="key == 'Collaborators'">
            <h2>{{ key }}</h2>
            <p v-for="(collab,idx) in value" :key="`${key}${idx}`" style="line-height:15px">
              <a :href="collab['homepage']">
                {{collab['name']}}
              </a>
              {{collab['danwei']}}
            </p>
          </div>
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
    std_cat: {},
    cards: ['Master', 'Undergraduate'] // 这里可以加入 Ph.D.以及 Past Members
  }),
  mounted () {
    this.std_cat = this.memberData
  }
}
</script>

<style>

</style>
